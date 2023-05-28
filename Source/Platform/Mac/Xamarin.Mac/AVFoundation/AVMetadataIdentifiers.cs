using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class AVMetadataIdentifiers
{
	public static class CommonIdentifier
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AlbumName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Artist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Artwork;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AssetIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Author;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Contributor;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Copyrights;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CreationDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Creator;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Description;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Format;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Language;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LastModifiedDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Location;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Make;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Model;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Publisher;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Relation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Software;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Source;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Subject;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Title;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Type;

		[Field("AVMetadataCommonIdentifierAlbumName", "AVFoundation")]
		public static NSString AlbumName
		{
			get
			{
				if (_AlbumName == null)
				{
					_AlbumName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAlbumName");
				}
				return _AlbumName;
			}
		}

		[Field("AVMetadataCommonIdentifierArtist", "AVFoundation")]
		public static NSString Artist
		{
			get
			{
				if (_Artist == null)
				{
					_Artist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierArtist");
				}
				return _Artist;
			}
		}

		[Field("AVMetadataCommonIdentifierArtwork", "AVFoundation")]
		public static NSString Artwork
		{
			get
			{
				if (_Artwork == null)
				{
					_Artwork = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierArtwork");
				}
				return _Artwork;
			}
		}

		[Field("AVMetadataCommonIdentifierAssetIdentifier", "AVFoundation")]
		public static NSString AssetIdentifier
		{
			get
			{
				if (_AssetIdentifier == null)
				{
					_AssetIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAssetIdentifier");
				}
				return _AssetIdentifier;
			}
		}

		[Field("AVMetadataCommonIdentifierAuthor", "AVFoundation")]
		public static NSString Author
		{
			get
			{
				if (_Author == null)
				{
					_Author = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAuthor");
				}
				return _Author;
			}
		}

		[Field("AVMetadataCommonIdentifierContributor", "AVFoundation")]
		public static NSString Contributor
		{
			get
			{
				if (_Contributor == null)
				{
					_Contributor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierContributor");
				}
				return _Contributor;
			}
		}

		[Field("AVMetadataCommonIdentifierCopyrights", "AVFoundation")]
		public static NSString Copyrights
		{
			get
			{
				if (_Copyrights == null)
				{
					_Copyrights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCopyrights");
				}
				return _Copyrights;
			}
		}

		[Field("AVMetadataCommonIdentifierCreationDate", "AVFoundation")]
		public static NSString CreationDate
		{
			get
			{
				if (_CreationDate == null)
				{
					_CreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCreationDate");
				}
				return _CreationDate;
			}
		}

		[Field("AVMetadataCommonIdentifierCreator", "AVFoundation")]
		public static NSString Creator
		{
			get
			{
				if (_Creator == null)
				{
					_Creator = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCreator");
				}
				return _Creator;
			}
		}

		[Field("AVMetadataCommonIdentifierDescription", "AVFoundation")]
		public static NSString Description
		{
			get
			{
				if (_Description == null)
				{
					_Description = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierDescription");
				}
				return _Description;
			}
		}

		[Field("AVMetadataCommonIdentifierFormat", "AVFoundation")]
		public static NSString Format
		{
			get
			{
				if (_Format == null)
				{
					_Format = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierFormat");
				}
				return _Format;
			}
		}

		[Field("AVMetadataCommonIdentifierLanguage", "AVFoundation")]
		public static NSString Language
		{
			get
			{
				if (_Language == null)
				{
					_Language = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLanguage");
				}
				return _Language;
			}
		}

		[Field("AVMetadataCommonIdentifierLastModifiedDate", "AVFoundation")]
		public static NSString LastModifiedDate
		{
			get
			{
				if (_LastModifiedDate == null)
				{
					_LastModifiedDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLastModifiedDate");
				}
				return _LastModifiedDate;
			}
		}

		[Field("AVMetadataCommonIdentifierLocation", "AVFoundation")]
		public static NSString Location
		{
			get
			{
				if (_Location == null)
				{
					_Location = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLocation");
				}
				return _Location;
			}
		}

		[Field("AVMetadataCommonIdentifierMake", "AVFoundation")]
		public static NSString Make
		{
			get
			{
				if (_Make == null)
				{
					_Make = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierMake");
				}
				return _Make;
			}
		}

		[Field("AVMetadataCommonIdentifierModel", "AVFoundation")]
		public static NSString Model
		{
			get
			{
				if (_Model == null)
				{
					_Model = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierModel");
				}
				return _Model;
			}
		}

		[Field("AVMetadataCommonIdentifierPublisher", "AVFoundation")]
		public static NSString Publisher
		{
			get
			{
				if (_Publisher == null)
				{
					_Publisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierPublisher");
				}
				return _Publisher;
			}
		}

		[Field("AVMetadataCommonIdentifierRelation", "AVFoundation")]
		public static NSString Relation
		{
			get
			{
				if (_Relation == null)
				{
					_Relation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierRelation");
				}
				return _Relation;
			}
		}

		[Field("AVMetadataCommonIdentifierSoftware", "AVFoundation")]
		public static NSString Software
		{
			get
			{
				if (_Software == null)
				{
					_Software = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSoftware");
				}
				return _Software;
			}
		}

		[Field("AVMetadataCommonIdentifierSource", "AVFoundation")]
		public static NSString Source
		{
			get
			{
				if (_Source == null)
				{
					_Source = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSource");
				}
				return _Source;
			}
		}

		[Field("AVMetadataCommonIdentifierSubject", "AVFoundation")]
		public static NSString Subject
		{
			get
			{
				if (_Subject == null)
				{
					_Subject = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSubject");
				}
				return _Subject;
			}
		}

		[Field("AVMetadataCommonIdentifierTitle", "AVFoundation")]
		public static NSString Title
		{
			get
			{
				if (_Title == null)
				{
					_Title = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierTitle");
				}
				return _Title;
			}
		}

		[Field("AVMetadataCommonIdentifierType", "AVFoundation")]
		public static NSString Type
		{
			get
			{
				if (_Type == null)
				{
					_Type = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierType");
				}
				return _Type;
			}
		}
	}

	public static class IcyMetadata
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _StreamTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _StreamUrl;

		[Field("AVMetadataIdentifierIcyMetadataStreamTitle", "AVFoundation")]
		public static NSString StreamTitle
		{
			get
			{
				if (_StreamTitle == null)
				{
					_StreamTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierIcyMetadataStreamTitle");
				}
				return _StreamTitle;
			}
		}

		[Field("AVMetadataIdentifierIcyMetadataStreamURL", "AVFoundation")]
		public static NSString StreamUrl
		{
			get
			{
				if (_StreamUrl == null)
				{
					_StreamUrl = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierIcyMetadataStreamURL");
				}
				return _StreamUrl;
			}
		}
	}

	public static class ID3Metadata
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AlbumSortOrder;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AlbumTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AttachedPicture;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AudioEncryption;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AudioSeekPointIndex;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Band;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _BeatsPerMinute;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Comments;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Commercial;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CommercialInformation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Commerical;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Composer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Conductor;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ContentGroupDescription;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ContentType;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Copyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CopyrightInformation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Date;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodedBy;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodedWith;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodingTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Encryption;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Equalization;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Equalization2;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EventTimingCodes;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _FileOwner;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _FileType;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _GeneralEncapsulatedObject;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _GroupIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InitialKey;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InternationalStandardRecordingCode;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InternetRadioStationName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InternetRadioStationOwner;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InvolvedPeopleList_v23;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _InvolvedPeopleList_v24;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Language;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LeadPerformer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Length;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Link;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Lyricist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _MediaType;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ModifiedBy;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Mood;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _MpegLocationLookupTable;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _MusicCDIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _MusicianCreditsList;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OfficialArtistWebpage;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OfficialAudioFileWebpage;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OfficialAudioSourceWebpage;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OfficialInternetRadioStationHomepage;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OfficialPublisherWebpage;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalAlbumTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalFilename;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalLyricist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalReleaseTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalReleaseYear;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Ownership;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PartOfASet;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Payment;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PerformerSortOrder;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PlayCounter;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PlaylistDelay;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Popularimeter;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PositionSynchronization;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Private;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ProducedNotice;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Publisher;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RecommendedBufferSize;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RecordingDates;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RecordingTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RelativeVolumeAdjustment;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RelativeVolumeAdjustment2;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ReleaseTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Reverb;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Seek;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SetSubtitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Signature;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Size;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SubTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SynchronizedLyric;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SynchronizedTempoCodes;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TaggingTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TermsOfUse;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Time;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TitleDescription;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TitleSortOrder;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TrackNumber;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UniqueFileIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UnsynchronizedLyric;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserText;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserUrl;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Year;

		[Field("AVMetadataIdentifierID3MetadataAlbumSortOrder", "AVFoundation")]
		public static NSString AlbumSortOrder
		{
			get
			{
				if (_AlbumSortOrder == null)
				{
					_AlbumSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAlbumSortOrder");
				}
				return _AlbumSortOrder;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataAlbumTitle", "AVFoundation")]
		public static NSString AlbumTitle
		{
			get
			{
				if (_AlbumTitle == null)
				{
					_AlbumTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAlbumTitle");
				}
				return _AlbumTitle;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataAttachedPicture", "AVFoundation")]
		public static NSString AttachedPicture
		{
			get
			{
				if (_AttachedPicture == null)
				{
					_AttachedPicture = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAttachedPicture");
				}
				return _AttachedPicture;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataAudioEncryption", "AVFoundation")]
		public static NSString AudioEncryption
		{
			get
			{
				if (_AudioEncryption == null)
				{
					_AudioEncryption = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAudioEncryption");
				}
				return _AudioEncryption;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataAudioSeekPointIndex", "AVFoundation")]
		public static NSString AudioSeekPointIndex
		{
			get
			{
				if (_AudioSeekPointIndex == null)
				{
					_AudioSeekPointIndex = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAudioSeekPointIndex");
				}
				return _AudioSeekPointIndex;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataBand", "AVFoundation")]
		public static NSString Band
		{
			get
			{
				if (_Band == null)
				{
					_Band = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataBand");
				}
				return _Band;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataBeatsPerMinute", "AVFoundation")]
		public static NSString BeatsPerMinute
		{
			get
			{
				if (_BeatsPerMinute == null)
				{
					_BeatsPerMinute = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataBeatsPerMinute");
				}
				return _BeatsPerMinute;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataComments", "AVFoundation")]
		public static NSString Comments
		{
			get
			{
				if (_Comments == null)
				{
					_Comments = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataComments");
				}
				return _Comments;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataCommercial", "AVFoundation")]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		public static NSString Commercial
		{
			[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
			get
			{
				if (_Commercial == null)
				{
					_Commercial = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommercial");
				}
				return _Commercial;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataCommercialInformation", "AVFoundation")]
		public static NSString CommercialInformation
		{
			get
			{
				if (_CommercialInformation == null)
				{
					_CommercialInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommercialInformation");
				}
				return _CommercialInformation;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataCommerical", "AVFoundation")]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		public static NSString Commerical
		{
			[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
			[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
			[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
			[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
			get
			{
				if (_Commerical == null)
				{
					_Commerical = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommerical");
				}
				return _Commerical;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataComposer", "AVFoundation")]
		public static NSString Composer
		{
			get
			{
				if (_Composer == null)
				{
					_Composer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataComposer");
				}
				return _Composer;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataConductor", "AVFoundation")]
		public static NSString Conductor
		{
			get
			{
				if (_Conductor == null)
				{
					_Conductor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataConductor");
				}
				return _Conductor;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataContentGroupDescription", "AVFoundation")]
		public static NSString ContentGroupDescription
		{
			get
			{
				if (_ContentGroupDescription == null)
				{
					_ContentGroupDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataContentGroupDescription");
				}
				return _ContentGroupDescription;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataContentType", "AVFoundation")]
		public static NSString ContentType
		{
			get
			{
				if (_ContentType == null)
				{
					_ContentType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataContentType");
				}
				return _ContentType;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataCopyright", "AVFoundation")]
		public static NSString Copyright
		{
			get
			{
				if (_Copyright == null)
				{
					_Copyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCopyright");
				}
				return _Copyright;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataCopyrightInformation", "AVFoundation")]
		public static NSString CopyrightInformation
		{
			get
			{
				if (_CopyrightInformation == null)
				{
					_CopyrightInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCopyrightInformation");
				}
				return _CopyrightInformation;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataDate", "AVFoundation")]
		public static NSString Date
		{
			get
			{
				if (_Date == null)
				{
					_Date = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataDate");
				}
				return _Date;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEncodedBy", "AVFoundation")]
		public static NSString EncodedBy
		{
			get
			{
				if (_EncodedBy == null)
				{
					_EncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodedBy");
				}
				return _EncodedBy;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEncodedWith", "AVFoundation")]
		public static NSString EncodedWith
		{
			get
			{
				if (_EncodedWith == null)
				{
					_EncodedWith = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodedWith");
				}
				return _EncodedWith;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEncodingTime", "AVFoundation")]
		public static NSString EncodingTime
		{
			get
			{
				if (_EncodingTime == null)
				{
					_EncodingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodingTime");
				}
				return _EncodingTime;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEncryption", "AVFoundation")]
		public static NSString Encryption
		{
			get
			{
				if (_Encryption == null)
				{
					_Encryption = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncryption");
				}
				return _Encryption;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEqualization", "AVFoundation")]
		public static NSString Equalization
		{
			get
			{
				if (_Equalization == null)
				{
					_Equalization = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEqualization");
				}
				return _Equalization;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEqualization2", "AVFoundation")]
		public static NSString Equalization2
		{
			get
			{
				if (_Equalization2 == null)
				{
					_Equalization2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEqualization2");
				}
				return _Equalization2;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataEventTimingCodes", "AVFoundation")]
		public static NSString EventTimingCodes
		{
			get
			{
				if (_EventTimingCodes == null)
				{
					_EventTimingCodes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEventTimingCodes");
				}
				return _EventTimingCodes;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataFileOwner", "AVFoundation")]
		public static NSString FileOwner
		{
			get
			{
				if (_FileOwner == null)
				{
					_FileOwner = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataFileOwner");
				}
				return _FileOwner;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataFileType", "AVFoundation")]
		public static NSString FileType
		{
			get
			{
				if (_FileType == null)
				{
					_FileType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataFileType");
				}
				return _FileType;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataGeneralEncapsulatedObject", "AVFoundation")]
		public static NSString GeneralEncapsulatedObject
		{
			get
			{
				if (_GeneralEncapsulatedObject == null)
				{
					_GeneralEncapsulatedObject = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataGeneralEncapsulatedObject");
				}
				return _GeneralEncapsulatedObject;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataGroupIdentifier", "AVFoundation")]
		public static NSString GroupIdentifier
		{
			get
			{
				if (_GroupIdentifier == null)
				{
					_GroupIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataGroupIdentifier");
				}
				return _GroupIdentifier;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInitialKey", "AVFoundation")]
		public static NSString InitialKey
		{
			get
			{
				if (_InitialKey == null)
				{
					_InitialKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInitialKey");
				}
				return _InitialKey;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInternationalStandardRecordingCode", "AVFoundation")]
		public static NSString InternationalStandardRecordingCode
		{
			get
			{
				if (_InternationalStandardRecordingCode == null)
				{
					_InternationalStandardRecordingCode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternationalStandardRecordingCode");
				}
				return _InternationalStandardRecordingCode;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInternetRadioStationName", "AVFoundation")]
		public static NSString InternetRadioStationName
		{
			get
			{
				if (_InternetRadioStationName == null)
				{
					_InternetRadioStationName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternetRadioStationName");
				}
				return _InternetRadioStationName;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInternetRadioStationOwner", "AVFoundation")]
		public static NSString InternetRadioStationOwner
		{
			get
			{
				if (_InternetRadioStationOwner == null)
				{
					_InternetRadioStationOwner = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternetRadioStationOwner");
				}
				return _InternetRadioStationOwner;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInvolvedPeopleList_v23", "AVFoundation")]
		public static NSString InvolvedPeopleList_v23
		{
			get
			{
				if (_InvolvedPeopleList_v23 == null)
				{
					_InvolvedPeopleList_v23 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInvolvedPeopleList_v23");
				}
				return _InvolvedPeopleList_v23;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataInvolvedPeopleList_v24", "AVFoundation")]
		public static NSString InvolvedPeopleList_v24
		{
			get
			{
				if (_InvolvedPeopleList_v24 == null)
				{
					_InvolvedPeopleList_v24 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInvolvedPeopleList_v24");
				}
				return _InvolvedPeopleList_v24;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataLanguage", "AVFoundation")]
		public static NSString Language
		{
			get
			{
				if (_Language == null)
				{
					_Language = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLanguage");
				}
				return _Language;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataLeadPerformer", "AVFoundation")]
		public static NSString LeadPerformer
		{
			get
			{
				if (_LeadPerformer == null)
				{
					_LeadPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLeadPerformer");
				}
				return _LeadPerformer;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataLength", "AVFoundation")]
		public static NSString Length
		{
			get
			{
				if (_Length == null)
				{
					_Length = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLength");
				}
				return _Length;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataLink", "AVFoundation")]
		public static NSString Link
		{
			get
			{
				if (_Link == null)
				{
					_Link = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLink");
				}
				return _Link;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataLyricist", "AVFoundation")]
		public static NSString Lyricist
		{
			get
			{
				if (_Lyricist == null)
				{
					_Lyricist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLyricist");
				}
				return _Lyricist;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataMediaType", "AVFoundation")]
		public static NSString MediaType
		{
			get
			{
				if (_MediaType == null)
				{
					_MediaType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMediaType");
				}
				return _MediaType;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataModifiedBy", "AVFoundation")]
		public static NSString ModifiedBy
		{
			get
			{
				if (_ModifiedBy == null)
				{
					_ModifiedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataModifiedBy");
				}
				return _ModifiedBy;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataMood", "AVFoundation")]
		public static NSString Mood
		{
			get
			{
				if (_Mood == null)
				{
					_Mood = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMood");
				}
				return _Mood;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataMPEGLocationLookupTable", "AVFoundation")]
		public static NSString MpegLocationLookupTable
		{
			get
			{
				if (_MpegLocationLookupTable == null)
				{
					_MpegLocationLookupTable = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMPEGLocationLookupTable");
				}
				return _MpegLocationLookupTable;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataMusicCDIdentifier", "AVFoundation")]
		public static NSString MusicCDIdentifier
		{
			get
			{
				if (_MusicCDIdentifier == null)
				{
					_MusicCDIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMusicCDIdentifier");
				}
				return _MusicCDIdentifier;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataMusicianCreditsList", "AVFoundation")]
		public static NSString MusicianCreditsList
		{
			get
			{
				if (_MusicianCreditsList == null)
				{
					_MusicianCreditsList = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMusicianCreditsList");
				}
				return _MusicianCreditsList;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOfficialArtistWebpage", "AVFoundation")]
		public static NSString OfficialArtistWebpage
		{
			get
			{
				if (_OfficialArtistWebpage == null)
				{
					_OfficialArtistWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialArtistWebpage");
				}
				return _OfficialArtistWebpage;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOfficialAudioFileWebpage", "AVFoundation")]
		public static NSString OfficialAudioFileWebpage
		{
			get
			{
				if (_OfficialAudioFileWebpage == null)
				{
					_OfficialAudioFileWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialAudioFileWebpage");
				}
				return _OfficialAudioFileWebpage;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOfficialAudioSourceWebpage", "AVFoundation")]
		public static NSString OfficialAudioSourceWebpage
		{
			get
			{
				if (_OfficialAudioSourceWebpage == null)
				{
					_OfficialAudioSourceWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialAudioSourceWebpage");
				}
				return _OfficialAudioSourceWebpage;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOfficialInternetRadioStationHomepage", "AVFoundation")]
		public static NSString OfficialInternetRadioStationHomepage
		{
			get
			{
				if (_OfficialInternetRadioStationHomepage == null)
				{
					_OfficialInternetRadioStationHomepage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialInternetRadioStationHomepage");
				}
				return _OfficialInternetRadioStationHomepage;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOfficialPublisherWebpage", "AVFoundation")]
		public static NSString OfficialPublisherWebpage
		{
			get
			{
				if (_OfficialPublisherWebpage == null)
				{
					_OfficialPublisherWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialPublisherWebpage");
				}
				return _OfficialPublisherWebpage;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalAlbumTitle", "AVFoundation")]
		public static NSString OriginalAlbumTitle
		{
			get
			{
				if (_OriginalAlbumTitle == null)
				{
					_OriginalAlbumTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalAlbumTitle");
				}
				return _OriginalAlbumTitle;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalArtist", "AVFoundation")]
		public static NSString OriginalArtist
		{
			get
			{
				if (_OriginalArtist == null)
				{
					_OriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalArtist");
				}
				return _OriginalArtist;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalFilename", "AVFoundation")]
		public static NSString OriginalFilename
		{
			get
			{
				if (_OriginalFilename == null)
				{
					_OriginalFilename = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalFilename");
				}
				return _OriginalFilename;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalLyricist", "AVFoundation")]
		public static NSString OriginalLyricist
		{
			get
			{
				if (_OriginalLyricist == null)
				{
					_OriginalLyricist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalLyricist");
				}
				return _OriginalLyricist;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalReleaseTime", "AVFoundation")]
		public static NSString OriginalReleaseTime
		{
			get
			{
				if (_OriginalReleaseTime == null)
				{
					_OriginalReleaseTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalReleaseTime");
				}
				return _OriginalReleaseTime;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOriginalReleaseYear", "AVFoundation")]
		public static NSString OriginalReleaseYear
		{
			get
			{
				if (_OriginalReleaseYear == null)
				{
					_OriginalReleaseYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalReleaseYear");
				}
				return _OriginalReleaseYear;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataOwnership", "AVFoundation")]
		public static NSString Ownership
		{
			get
			{
				if (_Ownership == null)
				{
					_Ownership = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOwnership");
				}
				return _Ownership;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPartOfASet", "AVFoundation")]
		public static NSString PartOfASet
		{
			get
			{
				if (_PartOfASet == null)
				{
					_PartOfASet = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPartOfASet");
				}
				return _PartOfASet;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPayment", "AVFoundation")]
		public static NSString Payment
		{
			get
			{
				if (_Payment == null)
				{
					_Payment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPayment");
				}
				return _Payment;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPerformerSortOrder", "AVFoundation")]
		public static NSString PerformerSortOrder
		{
			get
			{
				if (_PerformerSortOrder == null)
				{
					_PerformerSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPerformerSortOrder");
				}
				return _PerformerSortOrder;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPlayCounter", "AVFoundation")]
		public static NSString PlayCounter
		{
			get
			{
				if (_PlayCounter == null)
				{
					_PlayCounter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPlayCounter");
				}
				return _PlayCounter;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPlaylistDelay", "AVFoundation")]
		public static NSString PlaylistDelay
		{
			get
			{
				if (_PlaylistDelay == null)
				{
					_PlaylistDelay = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPlaylistDelay");
				}
				return _PlaylistDelay;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPopularimeter", "AVFoundation")]
		public static NSString Popularimeter
		{
			get
			{
				if (_Popularimeter == null)
				{
					_Popularimeter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPopularimeter");
				}
				return _Popularimeter;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPositionSynchronization", "AVFoundation")]
		public static NSString PositionSynchronization
		{
			get
			{
				if (_PositionSynchronization == null)
				{
					_PositionSynchronization = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPositionSynchronization");
				}
				return _PositionSynchronization;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPrivate", "AVFoundation")]
		public static NSString Private
		{
			get
			{
				if (_Private == null)
				{
					_Private = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPrivate");
				}
				return _Private;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataProducedNotice", "AVFoundation")]
		public static NSString ProducedNotice
		{
			get
			{
				if (_ProducedNotice == null)
				{
					_ProducedNotice = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataProducedNotice");
				}
				return _ProducedNotice;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataPublisher", "AVFoundation")]
		public static NSString Publisher
		{
			get
			{
				if (_Publisher == null)
				{
					_Publisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPublisher");
				}
				return _Publisher;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataRecommendedBufferSize", "AVFoundation")]
		public static NSString RecommendedBufferSize
		{
			get
			{
				if (_RecommendedBufferSize == null)
				{
					_RecommendedBufferSize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecommendedBufferSize");
				}
				return _RecommendedBufferSize;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataRecordingDates", "AVFoundation")]
		public static NSString RecordingDates
		{
			get
			{
				if (_RecordingDates == null)
				{
					_RecordingDates = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecordingDates");
				}
				return _RecordingDates;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataRecordingTime", "AVFoundation")]
		public static NSString RecordingTime
		{
			get
			{
				if (_RecordingTime == null)
				{
					_RecordingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecordingTime");
				}
				return _RecordingTime;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment", "AVFoundation")]
		public static NSString RelativeVolumeAdjustment
		{
			get
			{
				if (_RelativeVolumeAdjustment == null)
				{
					_RelativeVolumeAdjustment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment");
				}
				return _RelativeVolumeAdjustment;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment2", "AVFoundation")]
		public static NSString RelativeVolumeAdjustment2
		{
			get
			{
				if (_RelativeVolumeAdjustment2 == null)
				{
					_RelativeVolumeAdjustment2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment2");
				}
				return _RelativeVolumeAdjustment2;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataReleaseTime", "AVFoundation")]
		public static NSString ReleaseTime
		{
			get
			{
				if (_ReleaseTime == null)
				{
					_ReleaseTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataReleaseTime");
				}
				return _ReleaseTime;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataReverb", "AVFoundation")]
		public static NSString Reverb
		{
			get
			{
				if (_Reverb == null)
				{
					_Reverb = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataReverb");
				}
				return _Reverb;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSeek", "AVFoundation")]
		public static NSString Seek
		{
			get
			{
				if (_Seek == null)
				{
					_Seek = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSeek");
				}
				return _Seek;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSetSubtitle", "AVFoundation")]
		public static NSString SetSubtitle
		{
			get
			{
				if (_SetSubtitle == null)
				{
					_SetSubtitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSetSubtitle");
				}
				return _SetSubtitle;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSignature", "AVFoundation")]
		public static NSString Signature
		{
			get
			{
				if (_Signature == null)
				{
					_Signature = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSignature");
				}
				return _Signature;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSize", "AVFoundation")]
		public static NSString Size
		{
			get
			{
				if (_Size == null)
				{
					_Size = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSize");
				}
				return _Size;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSubTitle", "AVFoundation")]
		public static NSString SubTitle
		{
			get
			{
				if (_SubTitle == null)
				{
					_SubTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSubTitle");
				}
				return _SubTitle;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSynchronizedLyric", "AVFoundation")]
		public static NSString SynchronizedLyric
		{
			get
			{
				if (_SynchronizedLyric == null)
				{
					_SynchronizedLyric = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSynchronizedLyric");
				}
				return _SynchronizedLyric;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataSynchronizedTempoCodes", "AVFoundation")]
		public static NSString SynchronizedTempoCodes
		{
			get
			{
				if (_SynchronizedTempoCodes == null)
				{
					_SynchronizedTempoCodes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSynchronizedTempoCodes");
				}
				return _SynchronizedTempoCodes;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTaggingTime", "AVFoundation")]
		public static NSString TaggingTime
		{
			get
			{
				if (_TaggingTime == null)
				{
					_TaggingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTaggingTime");
				}
				return _TaggingTime;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTermsOfUse", "AVFoundation")]
		public static NSString TermsOfUse
		{
			get
			{
				if (_TermsOfUse == null)
				{
					_TermsOfUse = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTermsOfUse");
				}
				return _TermsOfUse;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTime", "AVFoundation")]
		public static NSString Time
		{
			get
			{
				if (_Time == null)
				{
					_Time = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTime");
				}
				return _Time;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTitleDescription", "AVFoundation")]
		public static NSString TitleDescription
		{
			get
			{
				if (_TitleDescription == null)
				{
					_TitleDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTitleDescription");
				}
				return _TitleDescription;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTitleSortOrder", "AVFoundation")]
		public static NSString TitleSortOrder
		{
			get
			{
				if (_TitleSortOrder == null)
				{
					_TitleSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTitleSortOrder");
				}
				return _TitleSortOrder;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataTrackNumber", "AVFoundation")]
		public static NSString TrackNumber
		{
			get
			{
				if (_TrackNumber == null)
				{
					_TrackNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTrackNumber");
				}
				return _TrackNumber;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataUniqueFileIdentifier", "AVFoundation")]
		public static NSString UniqueFileIdentifier
		{
			get
			{
				if (_UniqueFileIdentifier == null)
				{
					_UniqueFileIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUniqueFileIdentifier");
				}
				return _UniqueFileIdentifier;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataUnsynchronizedLyric", "AVFoundation")]
		public static NSString UnsynchronizedLyric
		{
			get
			{
				if (_UnsynchronizedLyric == null)
				{
					_UnsynchronizedLyric = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUnsynchronizedLyric");
				}
				return _UnsynchronizedLyric;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataUserText", "AVFoundation")]
		public static NSString UserText
		{
			get
			{
				if (_UserText == null)
				{
					_UserText = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUserText");
				}
				return _UserText;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataUserURL", "AVFoundation")]
		public static NSString UserUrl
		{
			get
			{
				if (_UserUrl == null)
				{
					_UserUrl = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUserURL");
				}
				return _UserUrl;
			}
		}

		[Field("AVMetadataIdentifierID3MetadataYear", "AVFoundation")]
		public static NSString Year
		{
			get
			{
				if (_Year == null)
				{
					_Year = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataYear");
				}
				return _Year;
			}
		}
	}

	public static class Iso
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCopyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataTaggedCharacteristic;

		[Field("AVMetadataIdentifierISOUserDataCopyright", "AVFoundation")]
		public static NSString UserDataCopyright
		{
			get
			{
				if (_UserDataCopyright == null)
				{
					_UserDataCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataCopyright");
				}
				return _UserDataCopyright;
			}
		}

		[Field("AVMetadataIdentifierISOUserDataDate", "AVFoundation")]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		public static NSString UserDataDate
		{
			[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
			get
			{
				if (_UserDataDate == null)
				{
					_UserDataDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataDate");
				}
				return _UserDataDate;
			}
		}

		[Field("AVMetadataIdentifierISOUserDataTaggedCharacteristic", "AVFoundation")]
		public static NSString UserDataTaggedCharacteristic
		{
			get
			{
				if (_UserDataTaggedCharacteristic == null)
				{
					_UserDataTaggedCharacteristic = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierISOUserDataTaggedCharacteristic");
				}
				return _UserDataTaggedCharacteristic;
			}
		}
	}

	public static class iTunesMetadata
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AccountKind;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Acknowledgement;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Album;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AlbumArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _AppleID;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Arranger;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ArtDirector;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Artist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ArtistID;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Author;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _BeatsPerMin;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Composer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Conductor;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ContentRating;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Copyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CoverArt;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Credits;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Description;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Director;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DiscCompilation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DiscNumber;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EQ;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodedBy;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodingTool;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ExecProducer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _GenreID;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Grouping;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LinerNotes;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Lyrics;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OnlineExtras;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Performer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PhonogramRights;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PlaylistID;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PredefinedGenre;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Producer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Publisher;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RecordCompany;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ReleaseDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Soloist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SongID;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SongName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _SoundEngineer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Thanks;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TrackNumber;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _TrackSubTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserComment;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserGenre;

		[Field("AVMetadataIdentifieriTunesMetadataAccountKind", "AVFoundation")]
		public static NSString AccountKind
		{
			get
			{
				if (_AccountKind == null)
				{
					_AccountKind = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAccountKind");
				}
				return _AccountKind;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataAcknowledgement", "AVFoundation")]
		public static NSString Acknowledgement
		{
			get
			{
				if (_Acknowledgement == null)
				{
					_Acknowledgement = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAcknowledgement");
				}
				return _Acknowledgement;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataAlbum", "AVFoundation")]
		public static NSString Album
		{
			get
			{
				if (_Album == null)
				{
					_Album = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAlbum");
				}
				return _Album;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataAlbumArtist", "AVFoundation")]
		public static NSString AlbumArtist
		{
			get
			{
				if (_AlbumArtist == null)
				{
					_AlbumArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAlbumArtist");
				}
				return _AlbumArtist;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataAppleID", "AVFoundation")]
		public static NSString AppleID
		{
			get
			{
				if (_AppleID == null)
				{
					_AppleID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAppleID");
				}
				return _AppleID;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataArranger", "AVFoundation")]
		public static NSString Arranger
		{
			get
			{
				if (_Arranger == null)
				{
					_Arranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArranger");
				}
				return _Arranger;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataArtDirector", "AVFoundation")]
		public static NSString ArtDirector
		{
			get
			{
				if (_ArtDirector == null)
				{
					_ArtDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtDirector");
				}
				return _ArtDirector;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataArtist", "AVFoundation")]
		public static NSString Artist
		{
			get
			{
				if (_Artist == null)
				{
					_Artist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtist");
				}
				return _Artist;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataArtistID", "AVFoundation")]
		public static NSString ArtistID
		{
			get
			{
				if (_ArtistID == null)
				{
					_ArtistID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataArtistID");
				}
				return _ArtistID;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataAuthor", "AVFoundation")]
		public static NSString Author
		{
			get
			{
				if (_Author == null)
				{
					_Author = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataAuthor");
				}
				return _Author;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataBeatsPerMin", "AVFoundation")]
		public static NSString BeatsPerMin
		{
			get
			{
				if (_BeatsPerMin == null)
				{
					_BeatsPerMin = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataBeatsPerMin");
				}
				return _BeatsPerMin;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataComposer", "AVFoundation")]
		public static NSString Composer
		{
			get
			{
				if (_Composer == null)
				{
					_Composer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataComposer");
				}
				return _Composer;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataConductor", "AVFoundation")]
		public static NSString Conductor
		{
			get
			{
				if (_Conductor == null)
				{
					_Conductor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataConductor");
				}
				return _Conductor;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataContentRating", "AVFoundation")]
		public static NSString ContentRating
		{
			get
			{
				if (_ContentRating == null)
				{
					_ContentRating = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataContentRating");
				}
				return _ContentRating;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataCopyright", "AVFoundation")]
		public static NSString Copyright
		{
			get
			{
				if (_Copyright == null)
				{
					_Copyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCopyright");
				}
				return _Copyright;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataCoverArt", "AVFoundation")]
		public static NSString CoverArt
		{
			get
			{
				if (_CoverArt == null)
				{
					_CoverArt = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCoverArt");
				}
				return _CoverArt;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataCredits", "AVFoundation")]
		public static NSString Credits
		{
			get
			{
				if (_Credits == null)
				{
					_Credits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataCredits");
				}
				return _Credits;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataDescription", "AVFoundation")]
		public static NSString Description
		{
			get
			{
				if (_Description == null)
				{
					_Description = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDescription");
				}
				return _Description;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataDirector", "AVFoundation")]
		public static NSString Director
		{
			get
			{
				if (_Director == null)
				{
					_Director = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDirector");
				}
				return _Director;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataDiscCompilation", "AVFoundation")]
		public static NSString DiscCompilation
		{
			get
			{
				if (_DiscCompilation == null)
				{
					_DiscCompilation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDiscCompilation");
				}
				return _DiscCompilation;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataDiscNumber", "AVFoundation")]
		public static NSString DiscNumber
		{
			get
			{
				if (_DiscNumber == null)
				{
					_DiscNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataDiscNumber");
				}
				return _DiscNumber;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataEQ", "AVFoundation")]
		public static NSString EQ
		{
			get
			{
				if (_EQ == null)
				{
					_EQ = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEQ");
				}
				return _EQ;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataEncodedBy", "AVFoundation")]
		public static NSString EncodedBy
		{
			get
			{
				if (_EncodedBy == null)
				{
					_EncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEncodedBy");
				}
				return _EncodedBy;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataEncodingTool", "AVFoundation")]
		public static NSString EncodingTool
		{
			get
			{
				if (_EncodingTool == null)
				{
					_EncodingTool = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataEncodingTool");
				}
				return _EncodingTool;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataExecProducer", "AVFoundation")]
		public static NSString ExecProducer
		{
			get
			{
				if (_ExecProducer == null)
				{
					_ExecProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataExecProducer");
				}
				return _ExecProducer;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataGenreID", "AVFoundation")]
		public static NSString GenreID
		{
			get
			{
				if (_GenreID == null)
				{
					_GenreID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataGenreID");
				}
				return _GenreID;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataGrouping", "AVFoundation")]
		public static NSString Grouping
		{
			get
			{
				if (_Grouping == null)
				{
					_Grouping = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataGrouping");
				}
				return _Grouping;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataLinerNotes", "AVFoundation")]
		public static NSString LinerNotes
		{
			get
			{
				if (_LinerNotes == null)
				{
					_LinerNotes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataLinerNotes");
				}
				return _LinerNotes;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataLyrics", "AVFoundation")]
		public static NSString Lyrics
		{
			get
			{
				if (_Lyrics == null)
				{
					_Lyrics = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataLyrics");
				}
				return _Lyrics;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataOnlineExtras", "AVFoundation")]
		public static NSString OnlineExtras
		{
			get
			{
				if (_OnlineExtras == null)
				{
					_OnlineExtras = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataOnlineExtras");
				}
				return _OnlineExtras;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataOriginalArtist", "AVFoundation")]
		public static NSString OriginalArtist
		{
			get
			{
				if (_OriginalArtist == null)
				{
					_OriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataOriginalArtist");
				}
				return _OriginalArtist;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataPerformer", "AVFoundation")]
		public static NSString Performer
		{
			get
			{
				if (_Performer == null)
				{
					_Performer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPerformer");
				}
				return _Performer;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataPhonogramRights", "AVFoundation")]
		public static NSString PhonogramRights
		{
			get
			{
				if (_PhonogramRights == null)
				{
					_PhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPhonogramRights");
				}
				return _PhonogramRights;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataPlaylistID", "AVFoundation")]
		public static NSString PlaylistID
		{
			get
			{
				if (_PlaylistID == null)
				{
					_PlaylistID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPlaylistID");
				}
				return _PlaylistID;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataPredefinedGenre", "AVFoundation")]
		public static NSString PredefinedGenre
		{
			get
			{
				if (_PredefinedGenre == null)
				{
					_PredefinedGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPredefinedGenre");
				}
				return _PredefinedGenre;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataProducer", "AVFoundation")]
		public static NSString Producer
		{
			get
			{
				if (_Producer == null)
				{
					_Producer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataProducer");
				}
				return _Producer;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataPublisher", "AVFoundation")]
		public static NSString Publisher
		{
			get
			{
				if (_Publisher == null)
				{
					_Publisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataPublisher");
				}
				return _Publisher;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataRecordCompany", "AVFoundation")]
		public static NSString RecordCompany
		{
			get
			{
				if (_RecordCompany == null)
				{
					_RecordCompany = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataRecordCompany");
				}
				return _RecordCompany;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataReleaseDate", "AVFoundation")]
		public static NSString ReleaseDate
		{
			get
			{
				if (_ReleaseDate == null)
				{
					_ReleaseDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataReleaseDate");
				}
				return _ReleaseDate;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataSoloist", "AVFoundation")]
		public static NSString Soloist
		{
			get
			{
				if (_Soloist == null)
				{
					_Soloist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSoloist");
				}
				return _Soloist;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataSongID", "AVFoundation")]
		public static NSString SongID
		{
			get
			{
				if (_SongID == null)
				{
					_SongID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSongID");
				}
				return _SongID;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataSongName", "AVFoundation")]
		public static NSString SongName
		{
			get
			{
				if (_SongName == null)
				{
					_SongName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSongName");
				}
				return _SongName;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataSoundEngineer", "AVFoundation")]
		public static NSString SoundEngineer
		{
			get
			{
				if (_SoundEngineer == null)
				{
					_SoundEngineer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataSoundEngineer");
				}
				return _SoundEngineer;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataThanks", "AVFoundation")]
		public static NSString Thanks
		{
			get
			{
				if (_Thanks == null)
				{
					_Thanks = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataThanks");
				}
				return _Thanks;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataTrackNumber", "AVFoundation")]
		public static NSString TrackNumber
		{
			get
			{
				if (_TrackNumber == null)
				{
					_TrackNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataTrackNumber");
				}
				return _TrackNumber;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataTrackSubTitle", "AVFoundation")]
		public static NSString TrackSubTitle
		{
			get
			{
				if (_TrackSubTitle == null)
				{
					_TrackSubTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataTrackSubTitle");
				}
				return _TrackSubTitle;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataUserComment", "AVFoundation")]
		public static NSString UserComment
		{
			get
			{
				if (_UserComment == null)
				{
					_UserComment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataUserComment");
				}
				return _UserComment;
			}
		}

		[Field("AVMetadataIdentifieriTunesMetadataUserGenre", "AVFoundation")]
		public static NSString UserGenre
		{
			get
			{
				if (_UserGenre == null)
				{
					_UserGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifieriTunesMetadataUserGenre");
				}
				return _UserGenre;
			}
		}
	}

	public static class QuickTime
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataAlbum;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataArranger;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataAuthor;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataChapter;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataComment;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataComposer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCopyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCreationDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCredits;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataDescription;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataDirector;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataDisclaimer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataEncodedBy;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataFullName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataGenre;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataHostComputer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataInformation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataKeywords;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataLocationISO6709;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataMake;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataModel;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataOriginalArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataOriginalFormat;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataOriginalSource;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataPerformers;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataPhonogramRights;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataProducer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataProduct;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataPublisher;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataSoftware;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataSpecialPlaybackRequirements;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataTaggedCharacteristic;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataTrack;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataTrackName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataUrlLink;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataWarning;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataWriter;

		[Field("AVMetadataIdentifierQuickTimeUserDataAlbum", "AVFoundation")]
		public static NSString UserDataAlbum
		{
			get
			{
				if (_UserDataAlbum == null)
				{
					_UserDataAlbum = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataAlbum");
				}
				return _UserDataAlbum;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataArranger", "AVFoundation")]
		public static NSString UserDataArranger
		{
			get
			{
				if (_UserDataArranger == null)
				{
					_UserDataArranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataArranger");
				}
				return _UserDataArranger;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataArtist", "AVFoundation")]
		public static NSString UserDataArtist
		{
			get
			{
				if (_UserDataArtist == null)
				{
					_UserDataArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataArtist");
				}
				return _UserDataArtist;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataAuthor", "AVFoundation")]
		public static NSString UserDataAuthor
		{
			get
			{
				if (_UserDataAuthor == null)
				{
					_UserDataAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataAuthor");
				}
				return _UserDataAuthor;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataChapter", "AVFoundation")]
		public static NSString UserDataChapter
		{
			get
			{
				if (_UserDataChapter == null)
				{
					_UserDataChapter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataChapter");
				}
				return _UserDataChapter;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataComment", "AVFoundation")]
		public static NSString UserDataComment
		{
			get
			{
				if (_UserDataComment == null)
				{
					_UserDataComment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataComment");
				}
				return _UserDataComment;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataComposer", "AVFoundation")]
		public static NSString UserDataComposer
		{
			get
			{
				if (_UserDataComposer == null)
				{
					_UserDataComposer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataComposer");
				}
				return _UserDataComposer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataCopyright", "AVFoundation")]
		public static NSString UserDataCopyright
		{
			get
			{
				if (_UserDataCopyright == null)
				{
					_UserDataCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCopyright");
				}
				return _UserDataCopyright;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataCreationDate", "AVFoundation")]
		public static NSString UserDataCreationDate
		{
			get
			{
				if (_UserDataCreationDate == null)
				{
					_UserDataCreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCreationDate");
				}
				return _UserDataCreationDate;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataCredits", "AVFoundation")]
		public static NSString UserDataCredits
		{
			get
			{
				if (_UserDataCredits == null)
				{
					_UserDataCredits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataCredits");
				}
				return _UserDataCredits;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataDescription", "AVFoundation")]
		public static NSString UserDataDescription
		{
			get
			{
				if (_UserDataDescription == null)
				{
					_UserDataDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDescription");
				}
				return _UserDataDescription;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataDirector", "AVFoundation")]
		public static NSString UserDataDirector
		{
			get
			{
				if (_UserDataDirector == null)
				{
					_UserDataDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDirector");
				}
				return _UserDataDirector;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataDisclaimer", "AVFoundation")]
		public static NSString UserDataDisclaimer
		{
			get
			{
				if (_UserDataDisclaimer == null)
				{
					_UserDataDisclaimer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataDisclaimer");
				}
				return _UserDataDisclaimer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataEncodedBy", "AVFoundation")]
		public static NSString UserDataEncodedBy
		{
			get
			{
				if (_UserDataEncodedBy == null)
				{
					_UserDataEncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataEncodedBy");
				}
				return _UserDataEncodedBy;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataFullName", "AVFoundation")]
		public static NSString UserDataFullName
		{
			get
			{
				if (_UserDataFullName == null)
				{
					_UserDataFullName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataFullName");
				}
				return _UserDataFullName;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataGenre", "AVFoundation")]
		public static NSString UserDataGenre
		{
			get
			{
				if (_UserDataGenre == null)
				{
					_UserDataGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataGenre");
				}
				return _UserDataGenre;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataHostComputer", "AVFoundation")]
		public static NSString UserDataHostComputer
		{
			get
			{
				if (_UserDataHostComputer == null)
				{
					_UserDataHostComputer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataHostComputer");
				}
				return _UserDataHostComputer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataInformation", "AVFoundation")]
		public static NSString UserDataInformation
		{
			get
			{
				if (_UserDataInformation == null)
				{
					_UserDataInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataInformation");
				}
				return _UserDataInformation;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataKeywords", "AVFoundation")]
		public static NSString UserDataKeywords
		{
			get
			{
				if (_UserDataKeywords == null)
				{
					_UserDataKeywords = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataKeywords");
				}
				return _UserDataKeywords;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataLocationISO6709", "AVFoundation")]
		public static NSString UserDataLocationISO6709
		{
			get
			{
				if (_UserDataLocationISO6709 == null)
				{
					_UserDataLocationISO6709 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataLocationISO6709");
				}
				return _UserDataLocationISO6709;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataMake", "AVFoundation")]
		public static NSString UserDataMake
		{
			get
			{
				if (_UserDataMake == null)
				{
					_UserDataMake = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataMake");
				}
				return _UserDataMake;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataModel", "AVFoundation")]
		public static NSString UserDataModel
		{
			get
			{
				if (_UserDataModel == null)
				{
					_UserDataModel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataModel");
				}
				return _UserDataModel;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataOriginalArtist", "AVFoundation")]
		public static NSString UserDataOriginalArtist
		{
			get
			{
				if (_UserDataOriginalArtist == null)
				{
					_UserDataOriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalArtist");
				}
				return _UserDataOriginalArtist;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataOriginalFormat", "AVFoundation")]
		public static NSString UserDataOriginalFormat
		{
			get
			{
				if (_UserDataOriginalFormat == null)
				{
					_UserDataOriginalFormat = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalFormat");
				}
				return _UserDataOriginalFormat;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataOriginalSource", "AVFoundation")]
		public static NSString UserDataOriginalSource
		{
			get
			{
				if (_UserDataOriginalSource == null)
				{
					_UserDataOriginalSource = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataOriginalSource");
				}
				return _UserDataOriginalSource;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataPerformers", "AVFoundation")]
		public static NSString UserDataPerformers
		{
			get
			{
				if (_UserDataPerformers == null)
				{
					_UserDataPerformers = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPerformers");
				}
				return _UserDataPerformers;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataPhonogramRights", "AVFoundation")]
		public static NSString UserDataPhonogramRights
		{
			get
			{
				if (_UserDataPhonogramRights == null)
				{
					_UserDataPhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPhonogramRights");
				}
				return _UserDataPhonogramRights;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataProducer", "AVFoundation")]
		public static NSString UserDataProducer
		{
			get
			{
				if (_UserDataProducer == null)
				{
					_UserDataProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataProducer");
				}
				return _UserDataProducer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataProduct", "AVFoundation")]
		public static NSString UserDataProduct
		{
			get
			{
				if (_UserDataProduct == null)
				{
					_UserDataProduct = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataProduct");
				}
				return _UserDataProduct;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataPublisher", "AVFoundation")]
		public static NSString UserDataPublisher
		{
			get
			{
				if (_UserDataPublisher == null)
				{
					_UserDataPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataPublisher");
				}
				return _UserDataPublisher;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataSoftware", "AVFoundation")]
		public static NSString UserDataSoftware
		{
			get
			{
				if (_UserDataSoftware == null)
				{
					_UserDataSoftware = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataSoftware");
				}
				return _UserDataSoftware;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataSpecialPlaybackRequirements", "AVFoundation")]
		public static NSString UserDataSpecialPlaybackRequirements
		{
			get
			{
				if (_UserDataSpecialPlaybackRequirements == null)
				{
					_UserDataSpecialPlaybackRequirements = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataSpecialPlaybackRequirements");
				}
				return _UserDataSpecialPlaybackRequirements;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataTaggedCharacteristic", "AVFoundation")]
		public static NSString UserDataTaggedCharacteristic
		{
			get
			{
				if (_UserDataTaggedCharacteristic == null)
				{
					_UserDataTaggedCharacteristic = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTaggedCharacteristic");
				}
				return _UserDataTaggedCharacteristic;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataTrack", "AVFoundation")]
		public static NSString UserDataTrack
		{
			get
			{
				if (_UserDataTrack == null)
				{
					_UserDataTrack = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTrack");
				}
				return _UserDataTrack;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataTrackName", "AVFoundation")]
		public static NSString UserDataTrackName
		{
			get
			{
				if (_UserDataTrackName == null)
				{
					_UserDataTrackName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataTrackName");
				}
				return _UserDataTrackName;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataURLLink", "AVFoundation")]
		public static NSString UserDataUrlLink
		{
			get
			{
				if (_UserDataUrlLink == null)
				{
					_UserDataUrlLink = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataURLLink");
				}
				return _UserDataUrlLink;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataWarning", "AVFoundation")]
		public static NSString UserDataWarning
		{
			get
			{
				if (_UserDataWarning == null)
				{
					_UserDataWarning = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataWarning");
				}
				return _UserDataWarning;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeUserDataWriter", "AVFoundation")]
		public static NSString UserDataWriter
		{
			get
			{
				if (_UserDataWriter == null)
				{
					_UserDataWriter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeUserDataWriter");
				}
				return _UserDataWriter;
			}
		}
	}

	public static class QuickTimeMetadata
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Album;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Arranger;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Artist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Artwork;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Author;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CameraFrameReadoutTime;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CameraIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CollectionUser;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Comment;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Composer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _ContentIdentifier;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Copyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _CreationDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Credits;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Description;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DetectedFace;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DirectionFacing;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DirectionMotion;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Director;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _DisplayName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _EncodedBy;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Genre;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Information;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Keywords;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationBody;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationDate;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationISO6709;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationName;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationNote;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _LocationRole;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Make;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Model;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _OriginalArtist;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Performer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PhonogramRights;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _PreferredAffineTransform;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Producer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Publisher;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _RatingUser;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Software;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Title;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _VideoOrientation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _Year;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _iXML;

		[Field("AVMetadataIdentifierQuickTimeMetadataAlbum", "AVFoundation")]
		public static NSString Album
		{
			get
			{
				if (_Album == null)
				{
					_Album = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAlbum");
				}
				return _Album;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataArranger", "AVFoundation")]
		public static NSString Arranger
		{
			get
			{
				if (_Arranger == null)
				{
					_Arranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArranger");
				}
				return _Arranger;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataArtist", "AVFoundation")]
		public static NSString Artist
		{
			get
			{
				if (_Artist == null)
				{
					_Artist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArtist");
				}
				return _Artist;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataArtwork", "AVFoundation")]
		public static NSString Artwork
		{
			get
			{
				if (_Artwork == null)
				{
					_Artwork = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataArtwork");
				}
				return _Artwork;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataAuthor", "AVFoundation")]
		public static NSString Author
		{
			get
			{
				if (_Author == null)
				{
					_Author = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataAuthor");
				}
				return _Author;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCameraFrameReadoutTime", "AVFoundation")]
		public static NSString CameraFrameReadoutTime
		{
			get
			{
				if (_CameraFrameReadoutTime == null)
				{
					_CameraFrameReadoutTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraFrameReadoutTime");
				}
				return _CameraFrameReadoutTime;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCameraIdentifier", "AVFoundation")]
		public static NSString CameraIdentifier
		{
			get
			{
				if (_CameraIdentifier == null)
				{
					_CameraIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCameraIdentifier");
				}
				return _CameraIdentifier;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCollectionUser", "AVFoundation")]
		public static NSString CollectionUser
		{
			get
			{
				if (_CollectionUser == null)
				{
					_CollectionUser = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCollectionUser");
				}
				return _CollectionUser;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataComment", "AVFoundation")]
		public static NSString Comment
		{
			get
			{
				if (_Comment == null)
				{
					_Comment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataComment");
				}
				return _Comment;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataComposer", "AVFoundation")]
		public static NSString Composer
		{
			get
			{
				if (_Composer == null)
				{
					_Composer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataComposer");
				}
				return _Composer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataContentIdentifier", "AVFoundation")]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		public static NSString ContentIdentifier
		{
			[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
			get
			{
				if (_ContentIdentifier == null)
				{
					_ContentIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataContentIdentifier");
				}
				return _ContentIdentifier;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCopyright", "AVFoundation")]
		public static NSString Copyright
		{
			get
			{
				if (_Copyright == null)
				{
					_Copyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCopyright");
				}
				return _Copyright;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCreationDate", "AVFoundation")]
		public static NSString CreationDate
		{
			get
			{
				if (_CreationDate == null)
				{
					_CreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCreationDate");
				}
				return _CreationDate;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataCredits", "AVFoundation")]
		public static NSString Credits
		{
			get
			{
				if (_Credits == null)
				{
					_Credits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataCredits");
				}
				return _Credits;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDescription", "AVFoundation")]
		public static NSString Description
		{
			get
			{
				if (_Description == null)
				{
					_Description = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDescription");
				}
				return _Description;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDetectedFace", "AVFoundation")]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		public static NSString DetectedFace
		{
			[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
			get
			{
				if (_DetectedFace == null)
				{
					_DetectedFace = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDetectedFace");
				}
				return _DetectedFace;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDirectionFacing", "AVFoundation")]
		public static NSString DirectionFacing
		{
			get
			{
				if (_DirectionFacing == null)
				{
					_DirectionFacing = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirectionFacing");
				}
				return _DirectionFacing;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDirectionMotion", "AVFoundation")]
		public static NSString DirectionMotion
		{
			get
			{
				if (_DirectionMotion == null)
				{
					_DirectionMotion = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirectionMotion");
				}
				return _DirectionMotion;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDirector", "AVFoundation")]
		public static NSString Director
		{
			get
			{
				if (_Director == null)
				{
					_Director = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDirector");
				}
				return _Director;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataDisplayName", "AVFoundation")]
		public static NSString DisplayName
		{
			get
			{
				if (_DisplayName == null)
				{
					_DisplayName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataDisplayName");
				}
				return _DisplayName;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataEncodedBy", "AVFoundation")]
		public static NSString EncodedBy
		{
			get
			{
				if (_EncodedBy == null)
				{
					_EncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataEncodedBy");
				}
				return _EncodedBy;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataGenre", "AVFoundation")]
		public static NSString Genre
		{
			get
			{
				if (_Genre == null)
				{
					_Genre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataGenre");
				}
				return _Genre;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataInformation", "AVFoundation")]
		public static NSString Information
		{
			get
			{
				if (_Information == null)
				{
					_Information = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataInformation");
				}
				return _Information;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataKeywords", "AVFoundation")]
		public static NSString Keywords
		{
			get
			{
				if (_Keywords == null)
				{
					_Keywords = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataKeywords");
				}
				return _Keywords;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationBody", "AVFoundation")]
		public static NSString LocationBody
		{
			get
			{
				if (_LocationBody == null)
				{
					_LocationBody = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationBody");
				}
				return _LocationBody;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationDate", "AVFoundation")]
		public static NSString LocationDate
		{
			get
			{
				if (_LocationDate == null)
				{
					_LocationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationDate");
				}
				return _LocationDate;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationISO6709", "AVFoundation")]
		public static NSString LocationISO6709
		{
			get
			{
				if (_LocationISO6709 == null)
				{
					_LocationISO6709 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationISO6709");
				}
				return _LocationISO6709;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationName", "AVFoundation")]
		public static NSString LocationName
		{
			get
			{
				if (_LocationName == null)
				{
					_LocationName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationName");
				}
				return _LocationName;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationNote", "AVFoundation")]
		public static NSString LocationNote
		{
			get
			{
				if (_LocationNote == null)
				{
					_LocationNote = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationNote");
				}
				return _LocationNote;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataLocationRole", "AVFoundation")]
		public static NSString LocationRole
		{
			get
			{
				if (_LocationRole == null)
				{
					_LocationRole = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataLocationRole");
				}
				return _LocationRole;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataMake", "AVFoundation")]
		public static NSString Make
		{
			get
			{
				if (_Make == null)
				{
					_Make = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataMake");
				}
				return _Make;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataModel", "AVFoundation")]
		public static NSString Model
		{
			get
			{
				if (_Model == null)
				{
					_Model = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataModel");
				}
				return _Model;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataOriginalArtist", "AVFoundation")]
		public static NSString OriginalArtist
		{
			get
			{
				if (_OriginalArtist == null)
				{
					_OriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataOriginalArtist");
				}
				return _OriginalArtist;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataPerformer", "AVFoundation")]
		public static NSString Performer
		{
			get
			{
				if (_Performer == null)
				{
					_Performer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPerformer");
				}
				return _Performer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataPhonogramRights", "AVFoundation")]
		public static NSString PhonogramRights
		{
			get
			{
				if (_PhonogramRights == null)
				{
					_PhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPhonogramRights");
				}
				return _PhonogramRights;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataPreferredAffineTransform", "AVFoundation")]
		public static NSString PreferredAffineTransform
		{
			get
			{
				if (_PreferredAffineTransform == null)
				{
					_PreferredAffineTransform = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPreferredAffineTransform");
				}
				return _PreferredAffineTransform;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataProducer", "AVFoundation")]
		public static NSString Producer
		{
			get
			{
				if (_Producer == null)
				{
					_Producer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataProducer");
				}
				return _Producer;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataPublisher", "AVFoundation")]
		public static NSString Publisher
		{
			get
			{
				if (_Publisher == null)
				{
					_Publisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataPublisher");
				}
				return _Publisher;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataRatingUser", "AVFoundation")]
		public static NSString RatingUser
		{
			get
			{
				if (_RatingUser == null)
				{
					_RatingUser = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataRatingUser");
				}
				return _RatingUser;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataSoftware", "AVFoundation")]
		public static NSString Software
		{
			get
			{
				if (_Software == null)
				{
					_Software = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataSoftware");
				}
				return _Software;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataTitle", "AVFoundation")]
		public static NSString Title
		{
			get
			{
				if (_Title == null)
				{
					_Title = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataTitle");
				}
				return _Title;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataVideoOrientation", "AVFoundation")]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		public static NSString VideoOrientation
		{
			[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
			[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
			get
			{
				if (_VideoOrientation == null)
				{
					_VideoOrientation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataVideoOrientation");
				}
				return _VideoOrientation;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataYear", "AVFoundation")]
		public static NSString Year
		{
			get
			{
				if (_Year == null)
				{
					_Year = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataYear");
				}
				return _Year;
			}
		}

		[Field("AVMetadataIdentifierQuickTimeMetadataiXML", "AVFoundation")]
		public static NSString iXML
		{
			get
			{
				if (_iXML == null)
				{
					_iXML = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifierQuickTimeMetadataiXML");
				}
				return _iXML;
			}
		}
	}

	public static class ThreeGP
	{
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataAlbumAndTrack;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataAuthor;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCollection;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataCopyright;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataDescription;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataGenre;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataKeywordList;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataLocation;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataMediaClassification;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataMediaRating;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataPerformer;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataRecordingYear;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataThumbnail;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataTitle;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private static NSString? _UserDataUserRating;

		[Field("AVMetadataIdentifier3GPUserDataAlbumAndTrack", "AVFoundation")]
		public static NSString UserDataAlbumAndTrack
		{
			get
			{
				if (_UserDataAlbumAndTrack == null)
				{
					_UserDataAlbumAndTrack = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataAlbumAndTrack");
				}
				return _UserDataAlbumAndTrack;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataAuthor", "AVFoundation")]
		public static NSString UserDataAuthor
		{
			get
			{
				if (_UserDataAuthor == null)
				{
					_UserDataAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataAuthor");
				}
				return _UserDataAuthor;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataCollection", "AVFoundation")]
		public static NSString UserDataCollection
		{
			get
			{
				if (_UserDataCollection == null)
				{
					_UserDataCollection = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataCollection");
				}
				return _UserDataCollection;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataCopyright", "AVFoundation")]
		public static NSString UserDataCopyright
		{
			get
			{
				if (_UserDataCopyright == null)
				{
					_UserDataCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataCopyright");
				}
				return _UserDataCopyright;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataDescription", "AVFoundation")]
		public static NSString UserDataDescription
		{
			get
			{
				if (_UserDataDescription == null)
				{
					_UserDataDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataDescription");
				}
				return _UserDataDescription;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataGenre", "AVFoundation")]
		public static NSString UserDataGenre
		{
			get
			{
				if (_UserDataGenre == null)
				{
					_UserDataGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataGenre");
				}
				return _UserDataGenre;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataKeywordList", "AVFoundation")]
		public static NSString UserDataKeywordList
		{
			get
			{
				if (_UserDataKeywordList == null)
				{
					_UserDataKeywordList = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataKeywordList");
				}
				return _UserDataKeywordList;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataLocation", "AVFoundation")]
		public static NSString UserDataLocation
		{
			get
			{
				if (_UserDataLocation == null)
				{
					_UserDataLocation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataLocation");
				}
				return _UserDataLocation;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataMediaClassification", "AVFoundation")]
		public static NSString UserDataMediaClassification
		{
			get
			{
				if (_UserDataMediaClassification == null)
				{
					_UserDataMediaClassification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataMediaClassification");
				}
				return _UserDataMediaClassification;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataMediaRating", "AVFoundation")]
		public static NSString UserDataMediaRating
		{
			get
			{
				if (_UserDataMediaRating == null)
				{
					_UserDataMediaRating = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataMediaRating");
				}
				return _UserDataMediaRating;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataPerformer", "AVFoundation")]
		public static NSString UserDataPerformer
		{
			get
			{
				if (_UserDataPerformer == null)
				{
					_UserDataPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataPerformer");
				}
				return _UserDataPerformer;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataRecordingYear", "AVFoundation")]
		public static NSString UserDataRecordingYear
		{
			get
			{
				if (_UserDataRecordingYear == null)
				{
					_UserDataRecordingYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataRecordingYear");
				}
				return _UserDataRecordingYear;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataThumbnail", "AVFoundation")]
		public static NSString UserDataThumbnail
		{
			get
			{
				if (_UserDataThumbnail == null)
				{
					_UserDataThumbnail = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataThumbnail");
				}
				return _UserDataThumbnail;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataTitle", "AVFoundation")]
		public static NSString UserDataTitle
		{
			get
			{
				if (_UserDataTitle == null)
				{
					_UserDataTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataTitle");
				}
				return _UserDataTitle;
			}
		}

		[Field("AVMetadataIdentifier3GPUserDataUserRating", "AVFoundation")]
		public static NSString UserDataUserRating
		{
			get
			{
				if (_UserDataUserRating == null)
				{
					_UserDataUserRating = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataIdentifier3GPUserDataUserRating");
				}
				return _UserDataUserRating;
			}
		}
	}
}
