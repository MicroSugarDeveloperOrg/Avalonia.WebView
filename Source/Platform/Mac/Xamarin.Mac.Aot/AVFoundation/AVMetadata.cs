using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVMetadata
{
	private static NSString _KeySpaceCommon;

	private static NSString _CommonKeyTitle;

	private static NSString _CommonKeyCreator;

	private static NSString _CommonKeySubject;

	private static NSString _CommonKeyDescription;

	private static NSString _CommonKeyPublisher;

	private static NSString _CommonKeyContributor;

	private static NSString _CommonKeyCreationDate;

	private static NSString _CommonKeyLastModifiedDate;

	private static NSString _CommonKeyType;

	private static NSString _CommonKeyFormat;

	private static NSString _CommonKeyIdentifier;

	private static NSString _CommonKeySource;

	private static NSString _CommonKeyLanguage;

	private static NSString _CommonKeyRelation;

	private static NSString _CommonKeyLocation;

	private static NSString _CommonKeyCopyrights;

	private static NSString _CommonKeyAlbumName;

	private static NSString _CommonKeyAuthor;

	private static NSString _CommonKeyArtist;

	private static NSString _CommonKeyArtwork;

	private static NSString _CommonKeyMake;

	private static NSString _CommonKeyModel;

	private static NSString _CommonKeySoftware;

	private static NSString _FormatQuickTimeUserData;

	private static NSString _KeySpaceQuickTimeUserData;

	private static NSString _QuickTimeUserDataKeyAlbum;

	private static NSString _QuickTimeUserDataKeyArranger;

	private static NSString _QuickTimeUserDataKeyArtist;

	private static NSString _QuickTimeUserDataKeyAuthor;

	private static NSString _QuickTimeUserDataKeyChapter;

	private static NSString _QuickTimeUserDataKeyComment;

	private static NSString _QuickTimeUserDataKeyComposer;

	private static NSString _QuickTimeUserDataKeyCopyright;

	private static NSString _QuickTimeUserDataKeyCreationDate;

	private static NSString _QuickTimeUserDataKeyDescription;

	private static NSString _QuickTimeUserDataKeyDirector;

	private static NSString _QuickTimeUserDataKeyDisclaimer;

	private static NSString _QuickTimeUserDataKeyEncodedBy;

	private static NSString _QuickTimeUserDataKeyFullName;

	private static NSString _QuickTimeUserDataKeyGenre;

	private static NSString _QuickTimeUserDataKeyHostComputer;

	private static NSString _QuickTimeUserDataKeyInformation;

	private static NSString _QuickTimeUserDataKeyKeywords;

	private static NSString _QuickTimeUserDataKeyMake;

	private static NSString _QuickTimeUserDataKeyModel;

	private static NSString _QuickTimeUserDataKeyOriginalArtist;

	private static NSString _QuickTimeUserDataKeyOriginalFormat;

	private static NSString _QuickTimeUserDataKeyOriginalSource;

	private static NSString _QuickTimeUserDataKeyPerformers;

	private static NSString _QuickTimeUserDataKeyProducer;

	private static NSString _QuickTimeUserDataKeyPublisher;

	private static NSString _QuickTimeUserDataKeyProduct;

	private static NSString _QuickTimeUserDataKeySoftware;

	private static NSString _QuickTimeUserDataKeySpecialPlaybackRequirements;

	private static NSString _QuickTimeUserDataKeyTrack;

	private static NSString _QuickTimeUserDataKeyWarning;

	private static NSString _QuickTimeUserDataKeyWriter;

	private static NSString _QuickTimeUserDataKeyURLLink;

	private static NSString _QuickTimeUserDataKeyLocationISO6709;

	private static NSString _QuickTimeUserDataKeyTrackName;

	private static NSString _QuickTimeUserDataKeyCredits;

	private static NSString _QuickTimeUserDataKeyPhonogramRights;

	private static NSString _QuickTimeUserDataKeyTaggedCharacteristic;

	private static NSString _ISOUserDataKeyCopyright;

	private static NSString _K3GPUserDataKeyCopyright;

	private static NSString _K3GPUserDataKeyAuthor;

	private static NSString _K3GPUserDataKeyPerformer;

	private static NSString _K3GPUserDataKeyGenre;

	private static NSString _K3GPUserDataKeyRecordingYear;

	private static NSString _K3GPUserDataKeyLocation;

	private static NSString _K3GPUserDataKeyTitle;

	private static NSString _K3GPUserDataKeyDescription;

	private static NSString _FormatQuickTimeMetadata;

	private static NSString _KeySpaceQuickTimeMetadata;

	private static NSString _QuickTimeMetadataKeyAuthor;

	private static NSString _QuickTimeMetadataKeyComment;

	private static NSString _QuickTimeMetadataKeyCopyright;

	private static NSString _QuickTimeMetadataKeyCreationDate;

	private static NSString _QuickTimeMetadataKeyDirector;

	private static NSString _QuickTimeMetadataKeyDisplayName;

	private static NSString _QuickTimeMetadataKeyInformation;

	private static NSString _QuickTimeMetadataKeyKeywords;

	private static NSString _QuickTimeMetadataKeyProducer;

	private static NSString _QuickTimeMetadataKeyPublisher;

	private static NSString _QuickTimeMetadataKeyAlbum;

	private static NSString _QuickTimeMetadataKeyArtist;

	private static NSString _QuickTimeMetadataKeyArtwork;

	private static NSString _QuickTimeMetadataKeyDescription;

	private static NSString _QuickTimeMetadataKeySoftware;

	private static NSString _QuickTimeMetadataKeyYear;

	private static NSString _QuickTimeMetadataKeyGenre;

	private static NSString _QuickTimeMetadataKeyiXML;

	private static NSString _QuickTimeMetadataKeyLocationISO6709;

	private static NSString _QuickTimeMetadataKeyMake;

	private static NSString _QuickTimeMetadataKeyModel;

	private static NSString _QuickTimeMetadataKeyArranger;

	private static NSString _QuickTimeMetadataKeyEncodedBy;

	private static NSString _QuickTimeMetadataKeyOriginalArtist;

	private static NSString _QuickTimeMetadataKeyPerformer;

	private static NSString _QuickTimeMetadataKeyComposer;

	private static NSString _QuickTimeMetadataKeyCredits;

	private static NSString _QuickTimeMetadataKeyPhonogramRights;

	private static NSString _QuickTimeMetadataKeyCameraIdentifier;

	private static NSString _QuickTimeMetadataKeyCameraFrameReadoutTime;

	private static NSString _QuickTimeMetadataKeyTitle;

	private static NSString _QuickTimeMetadataKeyCollectionUser;

	private static NSString _QuickTimeMetadataKeyRatingUser;

	private static NSString _QuickTimeMetadataKeyLocationName;

	private static NSString _QuickTimeMetadataKeyLocationBody;

	private static NSString _QuickTimeMetadataKeyLocationNote;

	private static NSString _QuickTimeMetadataKeyLocationRole;

	private static NSString _QuickTimeMetadataKeyLocationDate;

	private static NSString _QuickTimeMetadataKeyDirectionFacing;

	private static NSString _QuickTimeMetadataKeyDirectionMotion;

	private static NSString _FormatiTunesMetadata;

	private static NSString _KeySpaceiTunes;

	private static NSString _iTunesMetadataKeyAlbum;

	private static NSString _iTunesMetadataKeyArtist;

	private static NSString _iTunesMetadataKeyUserComment;

	private static NSString _iTunesMetadataKeyCoverArt;

	private static NSString _iTunesMetadataKeyCopyright;

	private static NSString _iTunesMetadataKeyReleaseDate;

	private static NSString _iTunesMetadataKeyEncodedBy;

	private static NSString _iTunesMetadataKeyPredefinedGenre;

	private static NSString _iTunesMetadataKeyUserGenre;

	private static NSString _iTunesMetadataKeySongName;

	private static NSString _iTunesMetadataKeyTrackSubTitle;

	private static NSString _iTunesMetadataKeyEncodingTool;

	private static NSString _iTunesMetadataKeyComposer;

	private static NSString _iTunesMetadataKeyAlbumArtist;

	private static NSString _iTunesMetadataKeyAccountKind;

	private static NSString _iTunesMetadataKeyAppleID;

	private static NSString _iTunesMetadataKeyArtistID;

	private static NSString _iTunesMetadataKeySongID;

	private static NSString _iTunesMetadataKeyDiscCompilation;

	private static NSString _iTunesMetadataKeyDiscNumber;

	private static NSString _iTunesMetadataKeyGenreID;

	private static NSString _iTunesMetadataKeyGrouping;

	private static NSString _iTunesMetadataKeyPlaylistID;

	private static NSString _iTunesMetadataKeyContentRating;

	private static NSString _iTunesMetadataKeyBeatsPerMin;

	private static NSString _iTunesMetadataKeyTrackNumber;

	private static NSString _iTunesMetadataKeyArtDirector;

	private static NSString _iTunesMetadataKeyArranger;

	private static NSString _iTunesMetadataKeyAuthor;

	private static NSString _iTunesMetadataKeyLyrics;

	private static NSString _iTunesMetadataKeyAcknowledgement;

	private static NSString _iTunesMetadataKeyConductor;

	private static NSString _iTunesMetadataKeyDescription;

	private static NSString _iTunesMetadataKeyDirector;

	private static NSString _iTunesMetadataKeyEQ;

	private static NSString _iTunesMetadataKeyLinerNotes;

	private static NSString _iTunesMetadataKeyRecordCompany;

	private static NSString _iTunesMetadataKeyOriginalArtist;

	private static NSString _iTunesMetadataKeyPhonogramRights;

	private static NSString _iTunesMetadataKeyProducer;

	private static NSString _iTunesMetadataKeyPerformer;

	private static NSString _iTunesMetadataKeyPublisher;

	private static NSString _iTunesMetadataKeySoundEngineer;

	private static NSString _iTunesMetadataKeySoloist;

	private static NSString _iTunesMetadataKeyCredits;

	private static NSString _iTunesMetadataKeyThanks;

	private static NSString _iTunesMetadataKeyOnlineExtras;

	private static NSString _iTunesMetadataKeyExecProducer;

	private static NSString _FormatID3Metadata;

	private static NSString _KeySpaceID3;

	private static NSString _ID3MetadataKeyAudioEncryption;

	private static NSString _ID3MetadataKeyAttachedPicture;

	private static NSString _ID3MetadataKeyAudioSeekPointIndex;

	private static NSString _ID3MetadataKeyComments;

	private static NSString _ID3MetadataKeyCommerical;

	private static NSString _ID3MetadataKeyEncryption;

	private static NSString _ID3MetadataKeyEqualization;

	private static NSString _ID3MetadataKeyEqualization2;

	private static NSString _ID3MetadataKeyEventTimingCodes;

	private static NSString _ID3MetadataKeyGeneralEncapsulatedObject;

	private static NSString _ID3MetadataKeyGroupIdentifier;

	private static NSString _ID3MetadataKeyInvolvedPeopleList;

	private static NSString _ID3MetadataKeyLink;

	private static NSString _ID3MetadataKeyMusicCDIdentifier;

	private static NSString _ID3MetadataKeyMPEGLocationLookupTable;

	private static NSString _ID3MetadataKeyOwnership;

	private static NSString _ID3MetadataKeyPrivate;

	private static NSString _ID3MetadataKeyPlayCounter;

	private static NSString _ID3MetadataKeyPopularimeter;

	private static NSString _ID3MetadataKeyPositionSynchronization;

	private static NSString _ID3MetadataKeyRecommendedBufferSize;

	private static NSString _ID3MetadataKeyRelativeVolumeAdjustment;

	private static NSString _ID3MetadataKeyRelativeVolumeAdjustment2;

	private static NSString _ID3MetadataKeyReverb;

	private static NSString _ID3MetadataKeySeek;

	private static NSString _ID3MetadataKeySignature;

	private static NSString _ID3MetadataKeySynchronizedLyric;

	private static NSString _ID3MetadataKeySynchronizedTempoCodes;

	private static NSString _ID3MetadataKeyAlbumTitle;

	private static NSString _ID3MetadataKeyBeatsPerMinute;

	private static NSString _ID3MetadataKeyComposer;

	private static NSString _ID3MetadataKeyContentType;

	private static NSString _ID3MetadataKeyCopyright;

	private static NSString _ID3MetadataKeyDate;

	private static NSString _ID3MetadataKeyEncodingTime;

	private static NSString _ID3MetadataKeyPlaylistDelay;

	private static NSString _ID3MetadataKeyOriginalReleaseTime;

	private static NSString _ID3MetadataKeyRecordingTime;

	private static NSString _ID3MetadataKeyReleaseTime;

	private static NSString _ID3MetadataKeyTaggingTime;

	private static NSString _ID3MetadataKeyEncodedBy;

	private static NSString _ID3MetadataKeyLyricist;

	private static NSString _ID3MetadataKeyFileType;

	private static NSString _ID3MetadataKeyTime;

	private static NSString _ID3MetadataKeyContentGroupDescription;

	private static NSString _ID3MetadataKeyTitleDescription;

	private static NSString _ID3MetadataKeySubTitle;

	private static NSString _ID3MetadataKeyInitialKey;

	private static NSString _ID3MetadataKeyLanguage;

	private static NSString _ID3MetadataKeyLength;

	private static NSString _ID3MetadataKeyMusicianCreditsList;

	private static NSString _ID3MetadataKeyMediaType;

	private static NSString _ID3MetadataKeyMood;

	private static NSString _ID3MetadataKeyOriginalAlbumTitle;

	private static NSString _ID3MetadataKeyOriginalFilename;

	private static NSString _ID3MetadataKeyOriginalLyricist;

	private static NSString _ID3MetadataKeyOriginalArtist;

	private static NSString _ID3MetadataKeyOriginalReleaseYear;

	private static NSString _ID3MetadataKeyFileOwner;

	private static NSString _ID3MetadataKeyLeadPerformer;

	private static NSString _ID3MetadataKeyBand;

	private static NSString _ID3MetadataKeyConductor;

	private static NSString _ID3MetadataKeyModifiedBy;

	private static NSString _ID3MetadataKeyPartOfASet;

	private static NSString _ID3MetadataKeyProducedNotice;

	private static NSString _ID3MetadataKeyPublisher;

	private static NSString _ID3MetadataKeyTrackNumber;

	private static NSString _ID3MetadataKeyRecordingDates;

	private static NSString _ID3MetadataKeyInternetRadioStationName;

	private static NSString _ID3MetadataKeyInternetRadioStationOwner;

	private static NSString _ID3MetadataKeySize;

	private static NSString _ID3MetadataKeyAlbumSortOrder;

	private static NSString _ID3MetadataKeyPerformerSortOrder;

	private static NSString _ID3MetadataKeyTitleSortOrder;

	private static NSString _ID3MetadataKeyInternationalStandardRecordingCode;

	private static NSString _ID3MetadataKeyEncodedWith;

	private static NSString _ID3MetadataKeySetSubtitle;

	private static NSString _ID3MetadataKeyYear;

	private static NSString _ID3MetadataKeyUserText;

	private static NSString _ID3MetadataKeyUniqueFileIdentifier;

	private static NSString _ID3MetadataKeyTermsOfUse;

	private static NSString _ID3MetadataKeyUnsynchronizedLyric;

	private static NSString _ID3MetadataKeyCommercialInformation;

	private static NSString _ID3MetadataKeyCopyrightInformation;

	private static NSString _ID3MetadataKeyOfficialAudioFileWebpage;

	private static NSString _ID3MetadataKeyOfficialArtistWebpage;

	private static NSString _ID3MetadataKeyOfficialAudioSourceWebpage;

	private static NSString _ID3MetadataKeyOfficialInternetRadioStationHomepage;

	private static NSString _ID3MetadataKeyPayment;

	private static NSString _ID3MetadataKeyOfficialPublisherWebpage;

	private static NSString _ID3MetadataKeyUserURL;

	[Field("AVMetadataKeySpaceCommon", "AVFoundation")]
	public static NSString KeySpaceCommon
	{
		get
		{
			if (_KeySpaceCommon == null)
			{
				_KeySpaceCommon = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataKeySpaceCommon");
			}
			return _KeySpaceCommon;
		}
	}

	[Field("AVMetadataCommonKeyTitle", "AVFoundation")]
	public static NSString CommonKeyTitle
	{
		get
		{
			if (_CommonKeyTitle == null)
			{
				_CommonKeyTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyTitle");
			}
			return _CommonKeyTitle;
		}
	}

	[Field("AVMetadataCommonKeyCreator", "AVFoundation")]
	public static NSString CommonKeyCreator
	{
		get
		{
			if (_CommonKeyCreator == null)
			{
				_CommonKeyCreator = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCreator");
			}
			return _CommonKeyCreator;
		}
	}

	[Field("AVMetadataCommonKeySubject", "AVFoundation")]
	public static NSString CommonKeySubject
	{
		get
		{
			if (_CommonKeySubject == null)
			{
				_CommonKeySubject = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeySubject");
			}
			return _CommonKeySubject;
		}
	}

	[Field("AVMetadataCommonKeyDescription", "AVFoundation")]
	public static NSString CommonKeyDescription
	{
		get
		{
			if (_CommonKeyDescription == null)
			{
				_CommonKeyDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyDescription");
			}
			return _CommonKeyDescription;
		}
	}

	[Field("AVMetadataCommonKeyPublisher", "AVFoundation")]
	public static NSString CommonKeyPublisher
	{
		get
		{
			if (_CommonKeyPublisher == null)
			{
				_CommonKeyPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyPublisher");
			}
			return _CommonKeyPublisher;
		}
	}

	[Field("AVMetadataCommonKeyContributor", "AVFoundation")]
	public static NSString CommonKeyContributor
	{
		get
		{
			if (_CommonKeyContributor == null)
			{
				_CommonKeyContributor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyContributor");
			}
			return _CommonKeyContributor;
		}
	}

	[Field("AVMetadataCommonKeyCreationDate", "AVFoundation")]
	public static NSString CommonKeyCreationDate
	{
		get
		{
			if (_CommonKeyCreationDate == null)
			{
				_CommonKeyCreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCreationDate");
			}
			return _CommonKeyCreationDate;
		}
	}

	[Field("AVMetadataCommonKeyLastModifiedDate", "AVFoundation")]
	public static NSString CommonKeyLastModifiedDate
	{
		get
		{
			if (_CommonKeyLastModifiedDate == null)
			{
				_CommonKeyLastModifiedDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLastModifiedDate");
			}
			return _CommonKeyLastModifiedDate;
		}
	}

	[Field("AVMetadataCommonKeyType", "AVFoundation")]
	public static NSString CommonKeyType
	{
		get
		{
			if (_CommonKeyType == null)
			{
				_CommonKeyType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyType");
			}
			return _CommonKeyType;
		}
	}

	[Field("AVMetadataCommonKeyFormat", "AVFoundation")]
	public static NSString CommonKeyFormat
	{
		get
		{
			if (_CommonKeyFormat == null)
			{
				_CommonKeyFormat = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyFormat");
			}
			return _CommonKeyFormat;
		}
	}

	[Field("AVMetadataCommonKeyIdentifier", "AVFoundation")]
	public static NSString CommonKeyIdentifier
	{
		get
		{
			if (_CommonKeyIdentifier == null)
			{
				_CommonKeyIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyIdentifier");
			}
			return _CommonKeyIdentifier;
		}
	}

	[Field("AVMetadataCommonKeySource", "AVFoundation")]
	public static NSString CommonKeySource
	{
		get
		{
			if (_CommonKeySource == null)
			{
				_CommonKeySource = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeySource");
			}
			return _CommonKeySource;
		}
	}

	[Field("AVMetadataCommonKeyLanguage", "AVFoundation")]
	public static NSString CommonKeyLanguage
	{
		get
		{
			if (_CommonKeyLanguage == null)
			{
				_CommonKeyLanguage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLanguage");
			}
			return _CommonKeyLanguage;
		}
	}

	[Field("AVMetadataCommonKeyRelation", "AVFoundation")]
	public static NSString CommonKeyRelation
	{
		get
		{
			if (_CommonKeyRelation == null)
			{
				_CommonKeyRelation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyRelation");
			}
			return _CommonKeyRelation;
		}
	}

	[Field("AVMetadataCommonKeyLocation", "AVFoundation")]
	public static NSString CommonKeyLocation
	{
		get
		{
			if (_CommonKeyLocation == null)
			{
				_CommonKeyLocation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyLocation");
			}
			return _CommonKeyLocation;
		}
	}

	[Field("AVMetadataCommonKeyCopyrights", "AVFoundation")]
	public static NSString CommonKeyCopyrights
	{
		get
		{
			if (_CommonKeyCopyrights == null)
			{
				_CommonKeyCopyrights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyCopyrights");
			}
			return _CommonKeyCopyrights;
		}
	}

	[Field("AVMetadataCommonKeyAlbumName", "AVFoundation")]
	public static NSString CommonKeyAlbumName
	{
		get
		{
			if (_CommonKeyAlbumName == null)
			{
				_CommonKeyAlbumName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyAlbumName");
			}
			return _CommonKeyAlbumName;
		}
	}

	[Field("AVMetadataCommonKeyAuthor", "AVFoundation")]
	public static NSString CommonKeyAuthor
	{
		get
		{
			if (_CommonKeyAuthor == null)
			{
				_CommonKeyAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyAuthor");
			}
			return _CommonKeyAuthor;
		}
	}

	[Field("AVMetadataCommonKeyArtist", "AVFoundation")]
	public static NSString CommonKeyArtist
	{
		get
		{
			if (_CommonKeyArtist == null)
			{
				_CommonKeyArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyArtist");
			}
			return _CommonKeyArtist;
		}
	}

	[Field("AVMetadataCommonKeyArtwork", "AVFoundation")]
	public static NSString CommonKeyArtwork
	{
		get
		{
			if (_CommonKeyArtwork == null)
			{
				_CommonKeyArtwork = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyArtwork");
			}
			return _CommonKeyArtwork;
		}
	}

	[Field("AVMetadataCommonKeyMake", "AVFoundation")]
	public static NSString CommonKeyMake
	{
		get
		{
			if (_CommonKeyMake == null)
			{
				_CommonKeyMake = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyMake");
			}
			return _CommonKeyMake;
		}
	}

	[Field("AVMetadataCommonKeyModel", "AVFoundation")]
	public static NSString CommonKeyModel
	{
		get
		{
			if (_CommonKeyModel == null)
			{
				_CommonKeyModel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeyModel");
			}
			return _CommonKeyModel;
		}
	}

	[Field("AVMetadataCommonKeySoftware", "AVFoundation")]
	public static NSString CommonKeySoftware
	{
		get
		{
			if (_CommonKeySoftware == null)
			{
				_CommonKeySoftware = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataCommonKeySoftware");
			}
			return _CommonKeySoftware;
		}
	}

	[Field("AVMetadataFormatQuickTimeUserData", "AVFoundation")]
	public static NSString FormatQuickTimeUserData
	{
		get
		{
			if (_FormatQuickTimeUserData == null)
			{
				_FormatQuickTimeUserData = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataFormatQuickTimeUserData");
			}
			return _FormatQuickTimeUserData;
		}
	}

	[Field("AVMetadataKeySpaceQuickTimeUserData", "AVFoundation")]
	public static NSString KeySpaceQuickTimeUserData
	{
		get
		{
			if (_KeySpaceQuickTimeUserData == null)
			{
				_KeySpaceQuickTimeUserData = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataKeySpaceQuickTimeUserData");
			}
			return _KeySpaceQuickTimeUserData;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyAlbum", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyAlbum
	{
		get
		{
			if (_QuickTimeUserDataKeyAlbum == null)
			{
				_QuickTimeUserDataKeyAlbum = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyAlbum");
			}
			return _QuickTimeUserDataKeyAlbum;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyArranger", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyArranger
	{
		get
		{
			if (_QuickTimeUserDataKeyArranger == null)
			{
				_QuickTimeUserDataKeyArranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyArranger");
			}
			return _QuickTimeUserDataKeyArranger;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyArtist", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyArtist
	{
		get
		{
			if (_QuickTimeUserDataKeyArtist == null)
			{
				_QuickTimeUserDataKeyArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyArtist");
			}
			return _QuickTimeUserDataKeyArtist;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyAuthor", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyAuthor
	{
		get
		{
			if (_QuickTimeUserDataKeyAuthor == null)
			{
				_QuickTimeUserDataKeyAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyAuthor");
			}
			return _QuickTimeUserDataKeyAuthor;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyChapter", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyChapter
	{
		get
		{
			if (_QuickTimeUserDataKeyChapter == null)
			{
				_QuickTimeUserDataKeyChapter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyChapter");
			}
			return _QuickTimeUserDataKeyChapter;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyComment", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyComment
	{
		get
		{
			if (_QuickTimeUserDataKeyComment == null)
			{
				_QuickTimeUserDataKeyComment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyComment");
			}
			return _QuickTimeUserDataKeyComment;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyComposer", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyComposer
	{
		get
		{
			if (_QuickTimeUserDataKeyComposer == null)
			{
				_QuickTimeUserDataKeyComposer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyComposer");
			}
			return _QuickTimeUserDataKeyComposer;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyCopyright", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyCopyright
	{
		get
		{
			if (_QuickTimeUserDataKeyCopyright == null)
			{
				_QuickTimeUserDataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCopyright");
			}
			return _QuickTimeUserDataKeyCopyright;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyCreationDate", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyCreationDate
	{
		get
		{
			if (_QuickTimeUserDataKeyCreationDate == null)
			{
				_QuickTimeUserDataKeyCreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCreationDate");
			}
			return _QuickTimeUserDataKeyCreationDate;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyDescription", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyDescription
	{
		get
		{
			if (_QuickTimeUserDataKeyDescription == null)
			{
				_QuickTimeUserDataKeyDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDescription");
			}
			return _QuickTimeUserDataKeyDescription;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyDirector", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyDirector
	{
		get
		{
			if (_QuickTimeUserDataKeyDirector == null)
			{
				_QuickTimeUserDataKeyDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDirector");
			}
			return _QuickTimeUserDataKeyDirector;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyDisclaimer", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyDisclaimer
	{
		get
		{
			if (_QuickTimeUserDataKeyDisclaimer == null)
			{
				_QuickTimeUserDataKeyDisclaimer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyDisclaimer");
			}
			return _QuickTimeUserDataKeyDisclaimer;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyEncodedBy", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyEncodedBy
	{
		get
		{
			if (_QuickTimeUserDataKeyEncodedBy == null)
			{
				_QuickTimeUserDataKeyEncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyEncodedBy");
			}
			return _QuickTimeUserDataKeyEncodedBy;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyFullName", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyFullName
	{
		get
		{
			if (_QuickTimeUserDataKeyFullName == null)
			{
				_QuickTimeUserDataKeyFullName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyFullName");
			}
			return _QuickTimeUserDataKeyFullName;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyGenre", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyGenre
	{
		get
		{
			if (_QuickTimeUserDataKeyGenre == null)
			{
				_QuickTimeUserDataKeyGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyGenre");
			}
			return _QuickTimeUserDataKeyGenre;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyHostComputer", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyHostComputer
	{
		get
		{
			if (_QuickTimeUserDataKeyHostComputer == null)
			{
				_QuickTimeUserDataKeyHostComputer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyHostComputer");
			}
			return _QuickTimeUserDataKeyHostComputer;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyInformation", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyInformation
	{
		get
		{
			if (_QuickTimeUserDataKeyInformation == null)
			{
				_QuickTimeUserDataKeyInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyInformation");
			}
			return _QuickTimeUserDataKeyInformation;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyKeywords", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyKeywords
	{
		get
		{
			if (_QuickTimeUserDataKeyKeywords == null)
			{
				_QuickTimeUserDataKeyKeywords = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyKeywords");
			}
			return _QuickTimeUserDataKeyKeywords;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyMake", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyMake
	{
		get
		{
			if (_QuickTimeUserDataKeyMake == null)
			{
				_QuickTimeUserDataKeyMake = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyMake");
			}
			return _QuickTimeUserDataKeyMake;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyModel", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyModel
	{
		get
		{
			if (_QuickTimeUserDataKeyModel == null)
			{
				_QuickTimeUserDataKeyModel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyModel");
			}
			return _QuickTimeUserDataKeyModel;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyOriginalArtist", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyOriginalArtist
	{
		get
		{
			if (_QuickTimeUserDataKeyOriginalArtist == null)
			{
				_QuickTimeUserDataKeyOriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalArtist");
			}
			return _QuickTimeUserDataKeyOriginalArtist;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyOriginalFormat", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyOriginalFormat
	{
		get
		{
			if (_QuickTimeUserDataKeyOriginalFormat == null)
			{
				_QuickTimeUserDataKeyOriginalFormat = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalFormat");
			}
			return _QuickTimeUserDataKeyOriginalFormat;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyOriginalSource", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyOriginalSource
	{
		get
		{
			if (_QuickTimeUserDataKeyOriginalSource == null)
			{
				_QuickTimeUserDataKeyOriginalSource = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyOriginalSource");
			}
			return _QuickTimeUserDataKeyOriginalSource;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyPerformers", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyPerformers
	{
		get
		{
			if (_QuickTimeUserDataKeyPerformers == null)
			{
				_QuickTimeUserDataKeyPerformers = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPerformers");
			}
			return _QuickTimeUserDataKeyPerformers;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyProducer", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyProducer
	{
		get
		{
			if (_QuickTimeUserDataKeyProducer == null)
			{
				_QuickTimeUserDataKeyProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyProducer");
			}
			return _QuickTimeUserDataKeyProducer;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyPublisher", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyPublisher
	{
		get
		{
			if (_QuickTimeUserDataKeyPublisher == null)
			{
				_QuickTimeUserDataKeyPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPublisher");
			}
			return _QuickTimeUserDataKeyPublisher;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyProduct", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyProduct
	{
		get
		{
			if (_QuickTimeUserDataKeyProduct == null)
			{
				_QuickTimeUserDataKeyProduct = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyProduct");
			}
			return _QuickTimeUserDataKeyProduct;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeySoftware", "AVFoundation")]
	public static NSString QuickTimeUserDataKeySoftware
	{
		get
		{
			if (_QuickTimeUserDataKeySoftware == null)
			{
				_QuickTimeUserDataKeySoftware = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeySoftware");
			}
			return _QuickTimeUserDataKeySoftware;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeySpecialPlaybackRequirements", "AVFoundation")]
	public static NSString QuickTimeUserDataKeySpecialPlaybackRequirements
	{
		get
		{
			if (_QuickTimeUserDataKeySpecialPlaybackRequirements == null)
			{
				_QuickTimeUserDataKeySpecialPlaybackRequirements = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeySpecialPlaybackRequirements");
			}
			return _QuickTimeUserDataKeySpecialPlaybackRequirements;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyTrack", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyTrack
	{
		get
		{
			if (_QuickTimeUserDataKeyTrack == null)
			{
				_QuickTimeUserDataKeyTrack = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTrack");
			}
			return _QuickTimeUserDataKeyTrack;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyWarning", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyWarning
	{
		get
		{
			if (_QuickTimeUserDataKeyWarning == null)
			{
				_QuickTimeUserDataKeyWarning = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyWarning");
			}
			return _QuickTimeUserDataKeyWarning;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyWriter", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyWriter
	{
		get
		{
			if (_QuickTimeUserDataKeyWriter == null)
			{
				_QuickTimeUserDataKeyWriter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyWriter");
			}
			return _QuickTimeUserDataKeyWriter;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyURLLink", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyURLLink
	{
		get
		{
			if (_QuickTimeUserDataKeyURLLink == null)
			{
				_QuickTimeUserDataKeyURLLink = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyURLLink");
			}
			return _QuickTimeUserDataKeyURLLink;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyLocationISO6709", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyLocationISO6709
	{
		get
		{
			if (_QuickTimeUserDataKeyLocationISO6709 == null)
			{
				_QuickTimeUserDataKeyLocationISO6709 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyLocationISO6709");
			}
			return _QuickTimeUserDataKeyLocationISO6709;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyTrackName", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyTrackName
	{
		get
		{
			if (_QuickTimeUserDataKeyTrackName == null)
			{
				_QuickTimeUserDataKeyTrackName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTrackName");
			}
			return _QuickTimeUserDataKeyTrackName;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyCredits", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyCredits
	{
		get
		{
			if (_QuickTimeUserDataKeyCredits == null)
			{
				_QuickTimeUserDataKeyCredits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyCredits");
			}
			return _QuickTimeUserDataKeyCredits;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyPhonogramRights", "AVFoundation")]
	public static NSString QuickTimeUserDataKeyPhonogramRights
	{
		get
		{
			if (_QuickTimeUserDataKeyPhonogramRights == null)
			{
				_QuickTimeUserDataKeyPhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyPhonogramRights");
			}
			return _QuickTimeUserDataKeyPhonogramRights;
		}
	}

	[Field("AVMetadataQuickTimeUserDataKeyTaggedCharacteristic", "AVFoundation")]
	[MountainLion]
	public static NSString QuickTimeUserDataKeyTaggedCharacteristic
	{
		[MountainLion]
		get
		{
			if (_QuickTimeUserDataKeyTaggedCharacteristic == null)
			{
				_QuickTimeUserDataKeyTaggedCharacteristic = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeUserDataKeyTaggedCharacteristic");
			}
			return _QuickTimeUserDataKeyTaggedCharacteristic;
		}
	}

	[Field("AVMetadataISOUserDataKeyCopyright", "AVFoundation")]
	public static NSString ISOUserDataKeyCopyright
	{
		get
		{
			if (_ISOUserDataKeyCopyright == null)
			{
				_ISOUserDataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataISOUserDataKeyCopyright");
			}
			return _ISOUserDataKeyCopyright;
		}
	}

	[Field("AVMetadata3GPUserDataKeyCopyright", "AVFoundation")]
	public static NSString K3GPUserDataKeyCopyright
	{
		get
		{
			if (_K3GPUserDataKeyCopyright == null)
			{
				_K3GPUserDataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyCopyright");
			}
			return _K3GPUserDataKeyCopyright;
		}
	}

	[Field("AVMetadata3GPUserDataKeyAuthor", "AVFoundation")]
	public static NSString K3GPUserDataKeyAuthor
	{
		get
		{
			if (_K3GPUserDataKeyAuthor == null)
			{
				_K3GPUserDataKeyAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyAuthor");
			}
			return _K3GPUserDataKeyAuthor;
		}
	}

	[Field("AVMetadata3GPUserDataKeyPerformer", "AVFoundation")]
	public static NSString K3GPUserDataKeyPerformer
	{
		get
		{
			if (_K3GPUserDataKeyPerformer == null)
			{
				_K3GPUserDataKeyPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyPerformer");
			}
			return _K3GPUserDataKeyPerformer;
		}
	}

	[Field("AVMetadata3GPUserDataKeyGenre", "AVFoundation")]
	public static NSString K3GPUserDataKeyGenre
	{
		get
		{
			if (_K3GPUserDataKeyGenre == null)
			{
				_K3GPUserDataKeyGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyGenre");
			}
			return _K3GPUserDataKeyGenre;
		}
	}

	[Field("AVMetadata3GPUserDataKeyRecordingYear", "AVFoundation")]
	public static NSString K3GPUserDataKeyRecordingYear
	{
		get
		{
			if (_K3GPUserDataKeyRecordingYear == null)
			{
				_K3GPUserDataKeyRecordingYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyRecordingYear");
			}
			return _K3GPUserDataKeyRecordingYear;
		}
	}

	[Field("AVMetadata3GPUserDataKeyLocation", "AVFoundation")]
	public static NSString K3GPUserDataKeyLocation
	{
		get
		{
			if (_K3GPUserDataKeyLocation == null)
			{
				_K3GPUserDataKeyLocation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyLocation");
			}
			return _K3GPUserDataKeyLocation;
		}
	}

	[Field("AVMetadata3GPUserDataKeyTitle", "AVFoundation")]
	public static NSString K3GPUserDataKeyTitle
	{
		get
		{
			if (_K3GPUserDataKeyTitle == null)
			{
				_K3GPUserDataKeyTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyTitle");
			}
			return _K3GPUserDataKeyTitle;
		}
	}

	[Field("AVMetadata3GPUserDataKeyDescription", "AVFoundation")]
	public static NSString K3GPUserDataKeyDescription
	{
		get
		{
			if (_K3GPUserDataKeyDescription == null)
			{
				_K3GPUserDataKeyDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadata3GPUserDataKeyDescription");
			}
			return _K3GPUserDataKeyDescription;
		}
	}

	[Field("AVMetadataFormatQuickTimeMetadata", "AVFoundation")]
	public static NSString FormatQuickTimeMetadata
	{
		get
		{
			if (_FormatQuickTimeMetadata == null)
			{
				_FormatQuickTimeMetadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataFormatQuickTimeMetadata");
			}
			return _FormatQuickTimeMetadata;
		}
	}

	[Field("AVMetadataKeySpaceQuickTimeMetadata", "AVFoundation")]
	public static NSString KeySpaceQuickTimeMetadata
	{
		get
		{
			if (_KeySpaceQuickTimeMetadata == null)
			{
				_KeySpaceQuickTimeMetadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataKeySpaceQuickTimeMetadata");
			}
			return _KeySpaceQuickTimeMetadata;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyAuthor", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyAuthor
	{
		get
		{
			if (_QuickTimeMetadataKeyAuthor == null)
			{
				_QuickTimeMetadataKeyAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyAuthor");
			}
			return _QuickTimeMetadataKeyAuthor;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyComment", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyComment
	{
		get
		{
			if (_QuickTimeMetadataKeyComment == null)
			{
				_QuickTimeMetadataKeyComment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyComment");
			}
			return _QuickTimeMetadataKeyComment;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCopyright", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCopyright
	{
		get
		{
			if (_QuickTimeMetadataKeyCopyright == null)
			{
				_QuickTimeMetadataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCopyright");
			}
			return _QuickTimeMetadataKeyCopyright;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCreationDate", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCreationDate
	{
		get
		{
			if (_QuickTimeMetadataKeyCreationDate == null)
			{
				_QuickTimeMetadataKeyCreationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCreationDate");
			}
			return _QuickTimeMetadataKeyCreationDate;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyDirector", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyDirector
	{
		get
		{
			if (_QuickTimeMetadataKeyDirector == null)
			{
				_QuickTimeMetadataKeyDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirector");
			}
			return _QuickTimeMetadataKeyDirector;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyDisplayName", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyDisplayName
	{
		get
		{
			if (_QuickTimeMetadataKeyDisplayName == null)
			{
				_QuickTimeMetadataKeyDisplayName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDisplayName");
			}
			return _QuickTimeMetadataKeyDisplayName;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyInformation", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyInformation
	{
		get
		{
			if (_QuickTimeMetadataKeyInformation == null)
			{
				_QuickTimeMetadataKeyInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyInformation");
			}
			return _QuickTimeMetadataKeyInformation;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyKeywords", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyKeywords
	{
		get
		{
			if (_QuickTimeMetadataKeyKeywords == null)
			{
				_QuickTimeMetadataKeyKeywords = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyKeywords");
			}
			return _QuickTimeMetadataKeyKeywords;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyProducer", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyProducer
	{
		get
		{
			if (_QuickTimeMetadataKeyProducer == null)
			{
				_QuickTimeMetadataKeyProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyProducer");
			}
			return _QuickTimeMetadataKeyProducer;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyPublisher", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyPublisher
	{
		get
		{
			if (_QuickTimeMetadataKeyPublisher == null)
			{
				_QuickTimeMetadataKeyPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPublisher");
			}
			return _QuickTimeMetadataKeyPublisher;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyAlbum", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyAlbum
	{
		get
		{
			if (_QuickTimeMetadataKeyAlbum == null)
			{
				_QuickTimeMetadataKeyAlbum = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyAlbum");
			}
			return _QuickTimeMetadataKeyAlbum;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyArtist", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyArtist
	{
		get
		{
			if (_QuickTimeMetadataKeyArtist == null)
			{
				_QuickTimeMetadataKeyArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArtist");
			}
			return _QuickTimeMetadataKeyArtist;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyArtwork", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyArtwork
	{
		get
		{
			if (_QuickTimeMetadataKeyArtwork == null)
			{
				_QuickTimeMetadataKeyArtwork = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArtwork");
			}
			return _QuickTimeMetadataKeyArtwork;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyDescription", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyDescription
	{
		get
		{
			if (_QuickTimeMetadataKeyDescription == null)
			{
				_QuickTimeMetadataKeyDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDescription");
			}
			return _QuickTimeMetadataKeyDescription;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeySoftware", "AVFoundation")]
	public static NSString QuickTimeMetadataKeySoftware
	{
		get
		{
			if (_QuickTimeMetadataKeySoftware == null)
			{
				_QuickTimeMetadataKeySoftware = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeySoftware");
			}
			return _QuickTimeMetadataKeySoftware;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyYear", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyYear
	{
		get
		{
			if (_QuickTimeMetadataKeyYear == null)
			{
				_QuickTimeMetadataKeyYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyYear");
			}
			return _QuickTimeMetadataKeyYear;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyGenre", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyGenre
	{
		get
		{
			if (_QuickTimeMetadataKeyGenre == null)
			{
				_QuickTimeMetadataKeyGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyGenre");
			}
			return _QuickTimeMetadataKeyGenre;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyiXML", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyiXML
	{
		get
		{
			if (_QuickTimeMetadataKeyiXML == null)
			{
				_QuickTimeMetadataKeyiXML = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyiXML");
			}
			return _QuickTimeMetadataKeyiXML;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationISO6709", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationISO6709
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationISO6709 == null)
			{
				_QuickTimeMetadataKeyLocationISO6709 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationISO6709");
			}
			return _QuickTimeMetadataKeyLocationISO6709;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyMake", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyMake
	{
		get
		{
			if (_QuickTimeMetadataKeyMake == null)
			{
				_QuickTimeMetadataKeyMake = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyMake");
			}
			return _QuickTimeMetadataKeyMake;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyModel", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyModel
	{
		get
		{
			if (_QuickTimeMetadataKeyModel == null)
			{
				_QuickTimeMetadataKeyModel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyModel");
			}
			return _QuickTimeMetadataKeyModel;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyArranger", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyArranger
	{
		get
		{
			if (_QuickTimeMetadataKeyArranger == null)
			{
				_QuickTimeMetadataKeyArranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyArranger");
			}
			return _QuickTimeMetadataKeyArranger;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyEncodedBy", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyEncodedBy
	{
		get
		{
			if (_QuickTimeMetadataKeyEncodedBy == null)
			{
				_QuickTimeMetadataKeyEncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyEncodedBy");
			}
			return _QuickTimeMetadataKeyEncodedBy;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyOriginalArtist", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyOriginalArtist
	{
		get
		{
			if (_QuickTimeMetadataKeyOriginalArtist == null)
			{
				_QuickTimeMetadataKeyOriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyOriginalArtist");
			}
			return _QuickTimeMetadataKeyOriginalArtist;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyPerformer", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyPerformer
	{
		get
		{
			if (_QuickTimeMetadataKeyPerformer == null)
			{
				_QuickTimeMetadataKeyPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPerformer");
			}
			return _QuickTimeMetadataKeyPerformer;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyComposer", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyComposer
	{
		get
		{
			if (_QuickTimeMetadataKeyComposer == null)
			{
				_QuickTimeMetadataKeyComposer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyComposer");
			}
			return _QuickTimeMetadataKeyComposer;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCredits", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCredits
	{
		get
		{
			if (_QuickTimeMetadataKeyCredits == null)
			{
				_QuickTimeMetadataKeyCredits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCredits");
			}
			return _QuickTimeMetadataKeyCredits;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyPhonogramRights", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyPhonogramRights
	{
		get
		{
			if (_QuickTimeMetadataKeyPhonogramRights == null)
			{
				_QuickTimeMetadataKeyPhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyPhonogramRights");
			}
			return _QuickTimeMetadataKeyPhonogramRights;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCameraIdentifier", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCameraIdentifier
	{
		get
		{
			if (_QuickTimeMetadataKeyCameraIdentifier == null)
			{
				_QuickTimeMetadataKeyCameraIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraIdentifier");
			}
			return _QuickTimeMetadataKeyCameraIdentifier;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCameraFrameReadoutTime", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCameraFrameReadoutTime
	{
		get
		{
			if (_QuickTimeMetadataKeyCameraFrameReadoutTime == null)
			{
				_QuickTimeMetadataKeyCameraFrameReadoutTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCameraFrameReadoutTime");
			}
			return _QuickTimeMetadataKeyCameraFrameReadoutTime;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyTitle", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyTitle
	{
		get
		{
			if (_QuickTimeMetadataKeyTitle == null)
			{
				_QuickTimeMetadataKeyTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyTitle");
			}
			return _QuickTimeMetadataKeyTitle;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyCollectionUser", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyCollectionUser
	{
		get
		{
			if (_QuickTimeMetadataKeyCollectionUser == null)
			{
				_QuickTimeMetadataKeyCollectionUser = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyCollectionUser");
			}
			return _QuickTimeMetadataKeyCollectionUser;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyRatingUser", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyRatingUser
	{
		get
		{
			if (_QuickTimeMetadataKeyRatingUser == null)
			{
				_QuickTimeMetadataKeyRatingUser = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyRatingUser");
			}
			return _QuickTimeMetadataKeyRatingUser;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationName", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationName
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationName == null)
			{
				_QuickTimeMetadataKeyLocationName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationName");
			}
			return _QuickTimeMetadataKeyLocationName;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationBody", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationBody
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationBody == null)
			{
				_QuickTimeMetadataKeyLocationBody = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationBody");
			}
			return _QuickTimeMetadataKeyLocationBody;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationNote", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationNote
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationNote == null)
			{
				_QuickTimeMetadataKeyLocationNote = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationNote");
			}
			return _QuickTimeMetadataKeyLocationNote;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationRole", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationRole
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationRole == null)
			{
				_QuickTimeMetadataKeyLocationRole = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationRole");
			}
			return _QuickTimeMetadataKeyLocationRole;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyLocationDate", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyLocationDate
	{
		get
		{
			if (_QuickTimeMetadataKeyLocationDate == null)
			{
				_QuickTimeMetadataKeyLocationDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyLocationDate");
			}
			return _QuickTimeMetadataKeyLocationDate;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyDirectionFacing", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyDirectionFacing
	{
		get
		{
			if (_QuickTimeMetadataKeyDirectionFacing == null)
			{
				_QuickTimeMetadataKeyDirectionFacing = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirectionFacing");
			}
			return _QuickTimeMetadataKeyDirectionFacing;
		}
	}

	[Field("AVMetadataQuickTimeMetadataKeyDirectionMotion", "AVFoundation")]
	public static NSString QuickTimeMetadataKeyDirectionMotion
	{
		get
		{
			if (_QuickTimeMetadataKeyDirectionMotion == null)
			{
				_QuickTimeMetadataKeyDirectionMotion = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataQuickTimeMetadataKeyDirectionMotion");
			}
			return _QuickTimeMetadataKeyDirectionMotion;
		}
	}

	[Field("AVMetadataFormatiTunesMetadata", "AVFoundation")]
	public static NSString FormatiTunesMetadata
	{
		get
		{
			if (_FormatiTunesMetadata == null)
			{
				_FormatiTunesMetadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataFormatiTunesMetadata");
			}
			return _FormatiTunesMetadata;
		}
	}

	[Field("AVMetadataKeySpaceiTunes", "AVFoundation")]
	public static NSString KeySpaceiTunes
	{
		get
		{
			if (_KeySpaceiTunes == null)
			{
				_KeySpaceiTunes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataKeySpaceiTunes");
			}
			return _KeySpaceiTunes;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAlbum", "AVFoundation")]
	public static NSString iTunesMetadataKeyAlbum
	{
		get
		{
			if (_iTunesMetadataKeyAlbum == null)
			{
				_iTunesMetadataKeyAlbum = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAlbum");
			}
			return _iTunesMetadataKeyAlbum;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyArtist", "AVFoundation")]
	public static NSString iTunesMetadataKeyArtist
	{
		get
		{
			if (_iTunesMetadataKeyArtist == null)
			{
				_iTunesMetadataKeyArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtist");
			}
			return _iTunesMetadataKeyArtist;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyUserComment", "AVFoundation")]
	public static NSString iTunesMetadataKeyUserComment
	{
		get
		{
			if (_iTunesMetadataKeyUserComment == null)
			{
				_iTunesMetadataKeyUserComment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyUserComment");
			}
			return _iTunesMetadataKeyUserComment;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyCoverArt", "AVFoundation")]
	public static NSString iTunesMetadataKeyCoverArt
	{
		get
		{
			if (_iTunesMetadataKeyCoverArt == null)
			{
				_iTunesMetadataKeyCoverArt = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCoverArt");
			}
			return _iTunesMetadataKeyCoverArt;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyCopyright", "AVFoundation")]
	public static NSString iTunesMetadataKeyCopyright
	{
		get
		{
			if (_iTunesMetadataKeyCopyright == null)
			{
				_iTunesMetadataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCopyright");
			}
			return _iTunesMetadataKeyCopyright;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyReleaseDate", "AVFoundation")]
	public static NSString iTunesMetadataKeyReleaseDate
	{
		get
		{
			if (_iTunesMetadataKeyReleaseDate == null)
			{
				_iTunesMetadataKeyReleaseDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyReleaseDate");
			}
			return _iTunesMetadataKeyReleaseDate;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyEncodedBy", "AVFoundation")]
	public static NSString iTunesMetadataKeyEncodedBy
	{
		get
		{
			if (_iTunesMetadataKeyEncodedBy == null)
			{
				_iTunesMetadataKeyEncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEncodedBy");
			}
			return _iTunesMetadataKeyEncodedBy;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyPredefinedGenre", "AVFoundation")]
	public static NSString iTunesMetadataKeyPredefinedGenre
	{
		get
		{
			if (_iTunesMetadataKeyPredefinedGenre == null)
			{
				_iTunesMetadataKeyPredefinedGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPredefinedGenre");
			}
			return _iTunesMetadataKeyPredefinedGenre;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyUserGenre", "AVFoundation")]
	public static NSString iTunesMetadataKeyUserGenre
	{
		get
		{
			if (_iTunesMetadataKeyUserGenre == null)
			{
				_iTunesMetadataKeyUserGenre = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyUserGenre");
			}
			return _iTunesMetadataKeyUserGenre;
		}
	}

	[Field("AVMetadataiTunesMetadataKeySongName", "AVFoundation")]
	public static NSString iTunesMetadataKeySongName
	{
		get
		{
			if (_iTunesMetadataKeySongName == null)
			{
				_iTunesMetadataKeySongName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySongName");
			}
			return _iTunesMetadataKeySongName;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyTrackSubTitle", "AVFoundation")]
	public static NSString iTunesMetadataKeyTrackSubTitle
	{
		get
		{
			if (_iTunesMetadataKeyTrackSubTitle == null)
			{
				_iTunesMetadataKeyTrackSubTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyTrackSubTitle");
			}
			return _iTunesMetadataKeyTrackSubTitle;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyEncodingTool", "AVFoundation")]
	public static NSString iTunesMetadataKeyEncodingTool
	{
		get
		{
			if (_iTunesMetadataKeyEncodingTool == null)
			{
				_iTunesMetadataKeyEncodingTool = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEncodingTool");
			}
			return _iTunesMetadataKeyEncodingTool;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyComposer", "AVFoundation")]
	public static NSString iTunesMetadataKeyComposer
	{
		get
		{
			if (_iTunesMetadataKeyComposer == null)
			{
				_iTunesMetadataKeyComposer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyComposer");
			}
			return _iTunesMetadataKeyComposer;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAlbumArtist", "AVFoundation")]
	public static NSString iTunesMetadataKeyAlbumArtist
	{
		get
		{
			if (_iTunesMetadataKeyAlbumArtist == null)
			{
				_iTunesMetadataKeyAlbumArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAlbumArtist");
			}
			return _iTunesMetadataKeyAlbumArtist;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAccountKind", "AVFoundation")]
	public static NSString iTunesMetadataKeyAccountKind
	{
		get
		{
			if (_iTunesMetadataKeyAccountKind == null)
			{
				_iTunesMetadataKeyAccountKind = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAccountKind");
			}
			return _iTunesMetadataKeyAccountKind;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAppleID", "AVFoundation")]
	public static NSString iTunesMetadataKeyAppleID
	{
		get
		{
			if (_iTunesMetadataKeyAppleID == null)
			{
				_iTunesMetadataKeyAppleID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAppleID");
			}
			return _iTunesMetadataKeyAppleID;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyArtistID", "AVFoundation")]
	public static NSString iTunesMetadataKeyArtistID
	{
		get
		{
			if (_iTunesMetadataKeyArtistID == null)
			{
				_iTunesMetadataKeyArtistID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtistID");
			}
			return _iTunesMetadataKeyArtistID;
		}
	}

	[Field("AVMetadataiTunesMetadataKeySongID", "AVFoundation")]
	public static NSString iTunesMetadataKeySongID
	{
		get
		{
			if (_iTunesMetadataKeySongID == null)
			{
				_iTunesMetadataKeySongID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySongID");
			}
			return _iTunesMetadataKeySongID;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyDiscCompilation", "AVFoundation")]
	public static NSString iTunesMetadataKeyDiscCompilation
	{
		get
		{
			if (_iTunesMetadataKeyDiscCompilation == null)
			{
				_iTunesMetadataKeyDiscCompilation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDiscCompilation");
			}
			return _iTunesMetadataKeyDiscCompilation;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyDiscNumber", "AVFoundation")]
	public static NSString iTunesMetadataKeyDiscNumber
	{
		get
		{
			if (_iTunesMetadataKeyDiscNumber == null)
			{
				_iTunesMetadataKeyDiscNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDiscNumber");
			}
			return _iTunesMetadataKeyDiscNumber;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyGenreID", "AVFoundation")]
	public static NSString iTunesMetadataKeyGenreID
	{
		get
		{
			if (_iTunesMetadataKeyGenreID == null)
			{
				_iTunesMetadataKeyGenreID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyGenreID");
			}
			return _iTunesMetadataKeyGenreID;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyGrouping", "AVFoundation")]
	public static NSString iTunesMetadataKeyGrouping
	{
		get
		{
			if (_iTunesMetadataKeyGrouping == null)
			{
				_iTunesMetadataKeyGrouping = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyGrouping");
			}
			return _iTunesMetadataKeyGrouping;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyPlaylistID", "AVFoundation")]
	public static NSString iTunesMetadataKeyPlaylistID
	{
		get
		{
			if (_iTunesMetadataKeyPlaylistID == null)
			{
				_iTunesMetadataKeyPlaylistID = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPlaylistID");
			}
			return _iTunesMetadataKeyPlaylistID;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyContentRating", "AVFoundation")]
	public static NSString iTunesMetadataKeyContentRating
	{
		get
		{
			if (_iTunesMetadataKeyContentRating == null)
			{
				_iTunesMetadataKeyContentRating = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyContentRating");
			}
			return _iTunesMetadataKeyContentRating;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyBeatsPerMin", "AVFoundation")]
	public static NSString iTunesMetadataKeyBeatsPerMin
	{
		get
		{
			if (_iTunesMetadataKeyBeatsPerMin == null)
			{
				_iTunesMetadataKeyBeatsPerMin = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyBeatsPerMin");
			}
			return _iTunesMetadataKeyBeatsPerMin;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyTrackNumber", "AVFoundation")]
	public static NSString iTunesMetadataKeyTrackNumber
	{
		get
		{
			if (_iTunesMetadataKeyTrackNumber == null)
			{
				_iTunesMetadataKeyTrackNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyTrackNumber");
			}
			return _iTunesMetadataKeyTrackNumber;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyArtDirector", "AVFoundation")]
	public static NSString iTunesMetadataKeyArtDirector
	{
		get
		{
			if (_iTunesMetadataKeyArtDirector == null)
			{
				_iTunesMetadataKeyArtDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArtDirector");
			}
			return _iTunesMetadataKeyArtDirector;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyArranger", "AVFoundation")]
	public static NSString iTunesMetadataKeyArranger
	{
		get
		{
			if (_iTunesMetadataKeyArranger == null)
			{
				_iTunesMetadataKeyArranger = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyArranger");
			}
			return _iTunesMetadataKeyArranger;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAuthor", "AVFoundation")]
	public static NSString iTunesMetadataKeyAuthor
	{
		get
		{
			if (_iTunesMetadataKeyAuthor == null)
			{
				_iTunesMetadataKeyAuthor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAuthor");
			}
			return _iTunesMetadataKeyAuthor;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyLyrics", "AVFoundation")]
	public static NSString iTunesMetadataKeyLyrics
	{
		get
		{
			if (_iTunesMetadataKeyLyrics == null)
			{
				_iTunesMetadataKeyLyrics = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyLyrics");
			}
			return _iTunesMetadataKeyLyrics;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyAcknowledgement", "AVFoundation")]
	public static NSString iTunesMetadataKeyAcknowledgement
	{
		get
		{
			if (_iTunesMetadataKeyAcknowledgement == null)
			{
				_iTunesMetadataKeyAcknowledgement = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyAcknowledgement");
			}
			return _iTunesMetadataKeyAcknowledgement;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyConductor", "AVFoundation")]
	public static NSString iTunesMetadataKeyConductor
	{
		get
		{
			if (_iTunesMetadataKeyConductor == null)
			{
				_iTunesMetadataKeyConductor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyConductor");
			}
			return _iTunesMetadataKeyConductor;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyDescription", "AVFoundation")]
	public static NSString iTunesMetadataKeyDescription
	{
		get
		{
			if (_iTunesMetadataKeyDescription == null)
			{
				_iTunesMetadataKeyDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDescription");
			}
			return _iTunesMetadataKeyDescription;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyDirector", "AVFoundation")]
	public static NSString iTunesMetadataKeyDirector
	{
		get
		{
			if (_iTunesMetadataKeyDirector == null)
			{
				_iTunesMetadataKeyDirector = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyDirector");
			}
			return _iTunesMetadataKeyDirector;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyEQ", "AVFoundation")]
	public static NSString iTunesMetadataKeyEQ
	{
		get
		{
			if (_iTunesMetadataKeyEQ == null)
			{
				_iTunesMetadataKeyEQ = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyEQ");
			}
			return _iTunesMetadataKeyEQ;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyLinerNotes", "AVFoundation")]
	public static NSString iTunesMetadataKeyLinerNotes
	{
		get
		{
			if (_iTunesMetadataKeyLinerNotes == null)
			{
				_iTunesMetadataKeyLinerNotes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyLinerNotes");
			}
			return _iTunesMetadataKeyLinerNotes;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyRecordCompany", "AVFoundation")]
	public static NSString iTunesMetadataKeyRecordCompany
	{
		get
		{
			if (_iTunesMetadataKeyRecordCompany == null)
			{
				_iTunesMetadataKeyRecordCompany = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyRecordCompany");
			}
			return _iTunesMetadataKeyRecordCompany;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyOriginalArtist", "AVFoundation")]
	public static NSString iTunesMetadataKeyOriginalArtist
	{
		get
		{
			if (_iTunesMetadataKeyOriginalArtist == null)
			{
				_iTunesMetadataKeyOriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyOriginalArtist");
			}
			return _iTunesMetadataKeyOriginalArtist;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyPhonogramRights", "AVFoundation")]
	public static NSString iTunesMetadataKeyPhonogramRights
	{
		get
		{
			if (_iTunesMetadataKeyPhonogramRights == null)
			{
				_iTunesMetadataKeyPhonogramRights = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPhonogramRights");
			}
			return _iTunesMetadataKeyPhonogramRights;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyProducer", "AVFoundation")]
	public static NSString iTunesMetadataKeyProducer
	{
		get
		{
			if (_iTunesMetadataKeyProducer == null)
			{
				_iTunesMetadataKeyProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyProducer");
			}
			return _iTunesMetadataKeyProducer;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyPerformer", "AVFoundation")]
	public static NSString iTunesMetadataKeyPerformer
	{
		get
		{
			if (_iTunesMetadataKeyPerformer == null)
			{
				_iTunesMetadataKeyPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPerformer");
			}
			return _iTunesMetadataKeyPerformer;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyPublisher", "AVFoundation")]
	public static NSString iTunesMetadataKeyPublisher
	{
		get
		{
			if (_iTunesMetadataKeyPublisher == null)
			{
				_iTunesMetadataKeyPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyPublisher");
			}
			return _iTunesMetadataKeyPublisher;
		}
	}

	[Field("AVMetadataiTunesMetadataKeySoundEngineer", "AVFoundation")]
	public static NSString iTunesMetadataKeySoundEngineer
	{
		get
		{
			if (_iTunesMetadataKeySoundEngineer == null)
			{
				_iTunesMetadataKeySoundEngineer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySoundEngineer");
			}
			return _iTunesMetadataKeySoundEngineer;
		}
	}

	[Field("AVMetadataiTunesMetadataKeySoloist", "AVFoundation")]
	public static NSString iTunesMetadataKeySoloist
	{
		get
		{
			if (_iTunesMetadataKeySoloist == null)
			{
				_iTunesMetadataKeySoloist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeySoloist");
			}
			return _iTunesMetadataKeySoloist;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyCredits", "AVFoundation")]
	public static NSString iTunesMetadataKeyCredits
	{
		get
		{
			if (_iTunesMetadataKeyCredits == null)
			{
				_iTunesMetadataKeyCredits = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyCredits");
			}
			return _iTunesMetadataKeyCredits;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyThanks", "AVFoundation")]
	public static NSString iTunesMetadataKeyThanks
	{
		get
		{
			if (_iTunesMetadataKeyThanks == null)
			{
				_iTunesMetadataKeyThanks = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyThanks");
			}
			return _iTunesMetadataKeyThanks;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyOnlineExtras", "AVFoundation")]
	public static NSString iTunesMetadataKeyOnlineExtras
	{
		get
		{
			if (_iTunesMetadataKeyOnlineExtras == null)
			{
				_iTunesMetadataKeyOnlineExtras = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyOnlineExtras");
			}
			return _iTunesMetadataKeyOnlineExtras;
		}
	}

	[Field("AVMetadataiTunesMetadataKeyExecProducer", "AVFoundation")]
	public static NSString iTunesMetadataKeyExecProducer
	{
		get
		{
			if (_iTunesMetadataKeyExecProducer == null)
			{
				_iTunesMetadataKeyExecProducer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataiTunesMetadataKeyExecProducer");
			}
			return _iTunesMetadataKeyExecProducer;
		}
	}

	[Field("AVMetadataFormatID3Metadata", "AVFoundation")]
	public static NSString FormatID3Metadata
	{
		get
		{
			if (_FormatID3Metadata == null)
			{
				_FormatID3Metadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataFormatID3Metadata");
			}
			return _FormatID3Metadata;
		}
	}

	[Field("AVMetadataKeySpaceID3", "AVFoundation")]
	public static NSString KeySpaceID3
	{
		get
		{
			if (_KeySpaceID3 == null)
			{
				_KeySpaceID3 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataKeySpaceID3");
			}
			return _KeySpaceID3;
		}
	}

	[Field("AVMetadataID3MetadataKeyAudioEncryption", "AVFoundation")]
	public static NSString ID3MetadataKeyAudioEncryption
	{
		get
		{
			if (_ID3MetadataKeyAudioEncryption == null)
			{
				_ID3MetadataKeyAudioEncryption = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAudioEncryption");
			}
			return _ID3MetadataKeyAudioEncryption;
		}
	}

	[Field("AVMetadataID3MetadataKeyAttachedPicture", "AVFoundation")]
	public static NSString ID3MetadataKeyAttachedPicture
	{
		get
		{
			if (_ID3MetadataKeyAttachedPicture == null)
			{
				_ID3MetadataKeyAttachedPicture = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAttachedPicture");
			}
			return _ID3MetadataKeyAttachedPicture;
		}
	}

	[Field("AVMetadataID3MetadataKeyAudioSeekPointIndex", "AVFoundation")]
	public static NSString ID3MetadataKeyAudioSeekPointIndex
	{
		get
		{
			if (_ID3MetadataKeyAudioSeekPointIndex == null)
			{
				_ID3MetadataKeyAudioSeekPointIndex = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAudioSeekPointIndex");
			}
			return _ID3MetadataKeyAudioSeekPointIndex;
		}
	}

	[Field("AVMetadataID3MetadataKeyComments", "AVFoundation")]
	public static NSString ID3MetadataKeyComments
	{
		get
		{
			if (_ID3MetadataKeyComments == null)
			{
				_ID3MetadataKeyComments = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyComments");
			}
			return _ID3MetadataKeyComments;
		}
	}

	[Field("AVMetadataID3MetadataKeyCommerical", "AVFoundation")]
	public static NSString ID3MetadataKeyCommerical
	{
		get
		{
			if (_ID3MetadataKeyCommerical == null)
			{
				_ID3MetadataKeyCommerical = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCommerical");
			}
			return _ID3MetadataKeyCommerical;
		}
	}

	[Field("AVMetadataID3MetadataKeyEncryption", "AVFoundation")]
	public static NSString ID3MetadataKeyEncryption
	{
		get
		{
			if (_ID3MetadataKeyEncryption == null)
			{
				_ID3MetadataKeyEncryption = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncryption");
			}
			return _ID3MetadataKeyEncryption;
		}
	}

	[Field("AVMetadataID3MetadataKeyEqualization", "AVFoundation")]
	public static NSString ID3MetadataKeyEqualization
	{
		get
		{
			if (_ID3MetadataKeyEqualization == null)
			{
				_ID3MetadataKeyEqualization = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEqualization");
			}
			return _ID3MetadataKeyEqualization;
		}
	}

	[Field("AVMetadataID3MetadataKeyEqualization2", "AVFoundation")]
	public static NSString ID3MetadataKeyEqualization2
	{
		get
		{
			if (_ID3MetadataKeyEqualization2 == null)
			{
				_ID3MetadataKeyEqualization2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEqualization2");
			}
			return _ID3MetadataKeyEqualization2;
		}
	}

	[Field("AVMetadataID3MetadataKeyEventTimingCodes", "AVFoundation")]
	public static NSString ID3MetadataKeyEventTimingCodes
	{
		get
		{
			if (_ID3MetadataKeyEventTimingCodes == null)
			{
				_ID3MetadataKeyEventTimingCodes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEventTimingCodes");
			}
			return _ID3MetadataKeyEventTimingCodes;
		}
	}

	[Field("AVMetadataID3MetadataKeyGeneralEncapsulatedObject", "AVFoundation")]
	public static NSString ID3MetadataKeyGeneralEncapsulatedObject
	{
		get
		{
			if (_ID3MetadataKeyGeneralEncapsulatedObject == null)
			{
				_ID3MetadataKeyGeneralEncapsulatedObject = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyGeneralEncapsulatedObject");
			}
			return _ID3MetadataKeyGeneralEncapsulatedObject;
		}
	}

	[Field("AVMetadataID3MetadataKeyGroupIdentifier", "AVFoundation")]
	public static NSString ID3MetadataKeyGroupIdentifier
	{
		get
		{
			if (_ID3MetadataKeyGroupIdentifier == null)
			{
				_ID3MetadataKeyGroupIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyGroupIdentifier");
			}
			return _ID3MetadataKeyGroupIdentifier;
		}
	}

	[Field("AVMetadataID3MetadataKeyInvolvedPeopleList_v23", "AVFoundation")]
	public static NSString ID3MetadataKeyInvolvedPeopleList
	{
		get
		{
			if (_ID3MetadataKeyInvolvedPeopleList == null)
			{
				_ID3MetadataKeyInvolvedPeopleList = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInvolvedPeopleList_v23");
			}
			return _ID3MetadataKeyInvolvedPeopleList;
		}
	}

	[Field("AVMetadataID3MetadataKeyLink", "AVFoundation")]
	public static NSString ID3MetadataKeyLink
	{
		get
		{
			if (_ID3MetadataKeyLink == null)
			{
				_ID3MetadataKeyLink = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLink");
			}
			return _ID3MetadataKeyLink;
		}
	}

	[Field("AVMetadataID3MetadataKeyMusicCDIdentifier", "AVFoundation")]
	public static NSString ID3MetadataKeyMusicCDIdentifier
	{
		get
		{
			if (_ID3MetadataKeyMusicCDIdentifier == null)
			{
				_ID3MetadataKeyMusicCDIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMusicCDIdentifier");
			}
			return _ID3MetadataKeyMusicCDIdentifier;
		}
	}

	[Field("AVMetadataID3MetadataKeyMPEGLocationLookupTable", "AVFoundation")]
	public static NSString ID3MetadataKeyMPEGLocationLookupTable
	{
		get
		{
			if (_ID3MetadataKeyMPEGLocationLookupTable == null)
			{
				_ID3MetadataKeyMPEGLocationLookupTable = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMPEGLocationLookupTable");
			}
			return _ID3MetadataKeyMPEGLocationLookupTable;
		}
	}

	[Field("AVMetadataID3MetadataKeyOwnership", "AVFoundation")]
	public static NSString ID3MetadataKeyOwnership
	{
		get
		{
			if (_ID3MetadataKeyOwnership == null)
			{
				_ID3MetadataKeyOwnership = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOwnership");
			}
			return _ID3MetadataKeyOwnership;
		}
	}

	[Field("AVMetadataID3MetadataKeyPrivate", "AVFoundation")]
	public static NSString ID3MetadataKeyPrivate
	{
		get
		{
			if (_ID3MetadataKeyPrivate == null)
			{
				_ID3MetadataKeyPrivate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPrivate");
			}
			return _ID3MetadataKeyPrivate;
		}
	}

	[Field("AVMetadataID3MetadataKeyPlayCounter", "AVFoundation")]
	public static NSString ID3MetadataKeyPlayCounter
	{
		get
		{
			if (_ID3MetadataKeyPlayCounter == null)
			{
				_ID3MetadataKeyPlayCounter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPlayCounter");
			}
			return _ID3MetadataKeyPlayCounter;
		}
	}

	[Field("AVMetadataID3MetadataKeyPopularimeter", "AVFoundation")]
	public static NSString ID3MetadataKeyPopularimeter
	{
		get
		{
			if (_ID3MetadataKeyPopularimeter == null)
			{
				_ID3MetadataKeyPopularimeter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPopularimeter");
			}
			return _ID3MetadataKeyPopularimeter;
		}
	}

	[Field("AVMetadataID3MetadataKeyPositionSynchronization", "AVFoundation")]
	public static NSString ID3MetadataKeyPositionSynchronization
	{
		get
		{
			if (_ID3MetadataKeyPositionSynchronization == null)
			{
				_ID3MetadataKeyPositionSynchronization = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPositionSynchronization");
			}
			return _ID3MetadataKeyPositionSynchronization;
		}
	}

	[Field("AVMetadataID3MetadataKeyRecommendedBufferSize", "AVFoundation")]
	public static NSString ID3MetadataKeyRecommendedBufferSize
	{
		get
		{
			if (_ID3MetadataKeyRecommendedBufferSize == null)
			{
				_ID3MetadataKeyRecommendedBufferSize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecommendedBufferSize");
			}
			return _ID3MetadataKeyRecommendedBufferSize;
		}
	}

	[Field("AVMetadataID3MetadataKeyRelativeVolumeAdjustment", "AVFoundation")]
	public static NSString ID3MetadataKeyRelativeVolumeAdjustment
	{
		get
		{
			if (_ID3MetadataKeyRelativeVolumeAdjustment == null)
			{
				_ID3MetadataKeyRelativeVolumeAdjustment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRelativeVolumeAdjustment");
			}
			return _ID3MetadataKeyRelativeVolumeAdjustment;
		}
	}

	[Field("AVMetadataID3MetadataKeyRelativeVolumeAdjustment2", "AVFoundation")]
	public static NSString ID3MetadataKeyRelativeVolumeAdjustment2
	{
		get
		{
			if (_ID3MetadataKeyRelativeVolumeAdjustment2 == null)
			{
				_ID3MetadataKeyRelativeVolumeAdjustment2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRelativeVolumeAdjustment2");
			}
			return _ID3MetadataKeyRelativeVolumeAdjustment2;
		}
	}

	[Field("AVMetadataID3MetadataKeyReverb", "AVFoundation")]
	public static NSString ID3MetadataKeyReverb
	{
		get
		{
			if (_ID3MetadataKeyReverb == null)
			{
				_ID3MetadataKeyReverb = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyReverb");
			}
			return _ID3MetadataKeyReverb;
		}
	}

	[Field("AVMetadataID3MetadataKeySeek", "AVFoundation")]
	public static NSString ID3MetadataKeySeek
	{
		get
		{
			if (_ID3MetadataKeySeek == null)
			{
				_ID3MetadataKeySeek = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySeek");
			}
			return _ID3MetadataKeySeek;
		}
	}

	[Field("AVMetadataID3MetadataKeySignature", "AVFoundation")]
	public static NSString ID3MetadataKeySignature
	{
		get
		{
			if (_ID3MetadataKeySignature == null)
			{
				_ID3MetadataKeySignature = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySignature");
			}
			return _ID3MetadataKeySignature;
		}
	}

	[Field("AVMetadataID3MetadataKeySynchronizedLyric", "AVFoundation")]
	public static NSString ID3MetadataKeySynchronizedLyric
	{
		get
		{
			if (_ID3MetadataKeySynchronizedLyric == null)
			{
				_ID3MetadataKeySynchronizedLyric = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySynchronizedLyric");
			}
			return _ID3MetadataKeySynchronizedLyric;
		}
	}

	[Field("AVMetadataID3MetadataKeySynchronizedTempoCodes", "AVFoundation")]
	public static NSString ID3MetadataKeySynchronizedTempoCodes
	{
		get
		{
			if (_ID3MetadataKeySynchronizedTempoCodes == null)
			{
				_ID3MetadataKeySynchronizedTempoCodes = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySynchronizedTempoCodes");
			}
			return _ID3MetadataKeySynchronizedTempoCodes;
		}
	}

	[Field("AVMetadataID3MetadataKeyAlbumTitle", "AVFoundation")]
	public static NSString ID3MetadataKeyAlbumTitle
	{
		get
		{
			if (_ID3MetadataKeyAlbumTitle == null)
			{
				_ID3MetadataKeyAlbumTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAlbumTitle");
			}
			return _ID3MetadataKeyAlbumTitle;
		}
	}

	[Field("AVMetadataID3MetadataKeyBeatsPerMinute", "AVFoundation")]
	public static NSString ID3MetadataKeyBeatsPerMinute
	{
		get
		{
			if (_ID3MetadataKeyBeatsPerMinute == null)
			{
				_ID3MetadataKeyBeatsPerMinute = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyBeatsPerMinute");
			}
			return _ID3MetadataKeyBeatsPerMinute;
		}
	}

	[Field("AVMetadataID3MetadataKeyComposer", "AVFoundation")]
	public static NSString ID3MetadataKeyComposer
	{
		get
		{
			if (_ID3MetadataKeyComposer == null)
			{
				_ID3MetadataKeyComposer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyComposer");
			}
			return _ID3MetadataKeyComposer;
		}
	}

	[Field("AVMetadataID3MetadataKeyContentType", "AVFoundation")]
	public static NSString ID3MetadataKeyContentType
	{
		get
		{
			if (_ID3MetadataKeyContentType == null)
			{
				_ID3MetadataKeyContentType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyContentType");
			}
			return _ID3MetadataKeyContentType;
		}
	}

	[Field("AVMetadataID3MetadataKeyCopyright", "AVFoundation")]
	public static NSString ID3MetadataKeyCopyright
	{
		get
		{
			if (_ID3MetadataKeyCopyright == null)
			{
				_ID3MetadataKeyCopyright = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCopyright");
			}
			return _ID3MetadataKeyCopyright;
		}
	}

	[Field("AVMetadataID3MetadataKeyDate", "AVFoundation")]
	public static NSString ID3MetadataKeyDate
	{
		get
		{
			if (_ID3MetadataKeyDate == null)
			{
				_ID3MetadataKeyDate = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyDate");
			}
			return _ID3MetadataKeyDate;
		}
	}

	[Field("AVMetadataID3MetadataKeyEncodingTime", "AVFoundation")]
	public static NSString ID3MetadataKeyEncodingTime
	{
		get
		{
			if (_ID3MetadataKeyEncodingTime == null)
			{
				_ID3MetadataKeyEncodingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodingTime");
			}
			return _ID3MetadataKeyEncodingTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyPlaylistDelay", "AVFoundation")]
	public static NSString ID3MetadataKeyPlaylistDelay
	{
		get
		{
			if (_ID3MetadataKeyPlaylistDelay == null)
			{
				_ID3MetadataKeyPlaylistDelay = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPlaylistDelay");
			}
			return _ID3MetadataKeyPlaylistDelay;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalReleaseTime", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalReleaseTime
	{
		get
		{
			if (_ID3MetadataKeyOriginalReleaseTime == null)
			{
				_ID3MetadataKeyOriginalReleaseTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalReleaseTime");
			}
			return _ID3MetadataKeyOriginalReleaseTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyRecordingTime", "AVFoundation")]
	public static NSString ID3MetadataKeyRecordingTime
	{
		get
		{
			if (_ID3MetadataKeyRecordingTime == null)
			{
				_ID3MetadataKeyRecordingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecordingTime");
			}
			return _ID3MetadataKeyRecordingTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyReleaseTime", "AVFoundation")]
	public static NSString ID3MetadataKeyReleaseTime
	{
		get
		{
			if (_ID3MetadataKeyReleaseTime == null)
			{
				_ID3MetadataKeyReleaseTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyReleaseTime");
			}
			return _ID3MetadataKeyReleaseTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyTaggingTime", "AVFoundation")]
	public static NSString ID3MetadataKeyTaggingTime
	{
		get
		{
			if (_ID3MetadataKeyTaggingTime == null)
			{
				_ID3MetadataKeyTaggingTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTaggingTime");
			}
			return _ID3MetadataKeyTaggingTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyEncodedBy", "AVFoundation")]
	public static NSString ID3MetadataKeyEncodedBy
	{
		get
		{
			if (_ID3MetadataKeyEncodedBy == null)
			{
				_ID3MetadataKeyEncodedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodedBy");
			}
			return _ID3MetadataKeyEncodedBy;
		}
	}

	[Field("AVMetadataID3MetadataKeyLyricist", "AVFoundation")]
	public static NSString ID3MetadataKeyLyricist
	{
		get
		{
			if (_ID3MetadataKeyLyricist == null)
			{
				_ID3MetadataKeyLyricist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLyricist");
			}
			return _ID3MetadataKeyLyricist;
		}
	}

	[Field("AVMetadataID3MetadataKeyFileType", "AVFoundation")]
	public static NSString ID3MetadataKeyFileType
	{
		get
		{
			if (_ID3MetadataKeyFileType == null)
			{
				_ID3MetadataKeyFileType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyFileType");
			}
			return _ID3MetadataKeyFileType;
		}
	}

	[Field("AVMetadataID3MetadataKeyTime", "AVFoundation")]
	public static NSString ID3MetadataKeyTime
	{
		get
		{
			if (_ID3MetadataKeyTime == null)
			{
				_ID3MetadataKeyTime = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTime");
			}
			return _ID3MetadataKeyTime;
		}
	}

	[Field("AVMetadataID3MetadataKeyContentGroupDescription", "AVFoundation")]
	public static NSString ID3MetadataKeyContentGroupDescription
	{
		get
		{
			if (_ID3MetadataKeyContentGroupDescription == null)
			{
				_ID3MetadataKeyContentGroupDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyContentGroupDescription");
			}
			return _ID3MetadataKeyContentGroupDescription;
		}
	}

	[Field("AVMetadataID3MetadataKeyTitleDescription", "AVFoundation")]
	public static NSString ID3MetadataKeyTitleDescription
	{
		get
		{
			if (_ID3MetadataKeyTitleDescription == null)
			{
				_ID3MetadataKeyTitleDescription = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTitleDescription");
			}
			return _ID3MetadataKeyTitleDescription;
		}
	}

	[Field("AVMetadataID3MetadataKeySubTitle", "AVFoundation")]
	public static NSString ID3MetadataKeySubTitle
	{
		get
		{
			if (_ID3MetadataKeySubTitle == null)
			{
				_ID3MetadataKeySubTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySubTitle");
			}
			return _ID3MetadataKeySubTitle;
		}
	}

	[Field("AVMetadataID3MetadataKeyInitialKey", "AVFoundation")]
	public static NSString ID3MetadataKeyInitialKey
	{
		get
		{
			if (_ID3MetadataKeyInitialKey == null)
			{
				_ID3MetadataKeyInitialKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInitialKey");
			}
			return _ID3MetadataKeyInitialKey;
		}
	}

	[Field("AVMetadataID3MetadataKeyLanguage", "AVFoundation")]
	public static NSString ID3MetadataKeyLanguage
	{
		get
		{
			if (_ID3MetadataKeyLanguage == null)
			{
				_ID3MetadataKeyLanguage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLanguage");
			}
			return _ID3MetadataKeyLanguage;
		}
	}

	[Field("AVMetadataID3MetadataKeyLength", "AVFoundation")]
	public static NSString ID3MetadataKeyLength
	{
		get
		{
			if (_ID3MetadataKeyLength == null)
			{
				_ID3MetadataKeyLength = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLength");
			}
			return _ID3MetadataKeyLength;
		}
	}

	[Field("AVMetadataID3MetadataKeyMusicianCreditsList", "AVFoundation")]
	public static NSString ID3MetadataKeyMusicianCreditsList
	{
		get
		{
			if (_ID3MetadataKeyMusicianCreditsList == null)
			{
				_ID3MetadataKeyMusicianCreditsList = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMusicianCreditsList");
			}
			return _ID3MetadataKeyMusicianCreditsList;
		}
	}

	[Field("AVMetadataID3MetadataKeyMediaType", "AVFoundation")]
	public static NSString ID3MetadataKeyMediaType
	{
		get
		{
			if (_ID3MetadataKeyMediaType == null)
			{
				_ID3MetadataKeyMediaType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMediaType");
			}
			return _ID3MetadataKeyMediaType;
		}
	}

	[Field("AVMetadataID3MetadataKeyMood", "AVFoundation")]
	public static NSString ID3MetadataKeyMood
	{
		get
		{
			if (_ID3MetadataKeyMood == null)
			{
				_ID3MetadataKeyMood = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyMood");
			}
			return _ID3MetadataKeyMood;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalAlbumTitle", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalAlbumTitle
	{
		get
		{
			if (_ID3MetadataKeyOriginalAlbumTitle == null)
			{
				_ID3MetadataKeyOriginalAlbumTitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalAlbumTitle");
			}
			return _ID3MetadataKeyOriginalAlbumTitle;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalFilename", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalFilename
	{
		get
		{
			if (_ID3MetadataKeyOriginalFilename == null)
			{
				_ID3MetadataKeyOriginalFilename = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalFilename");
			}
			return _ID3MetadataKeyOriginalFilename;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalLyricist", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalLyricist
	{
		get
		{
			if (_ID3MetadataKeyOriginalLyricist == null)
			{
				_ID3MetadataKeyOriginalLyricist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalLyricist");
			}
			return _ID3MetadataKeyOriginalLyricist;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalArtist", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalArtist
	{
		get
		{
			if (_ID3MetadataKeyOriginalArtist == null)
			{
				_ID3MetadataKeyOriginalArtist = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalArtist");
			}
			return _ID3MetadataKeyOriginalArtist;
		}
	}

	[Field("AVMetadataID3MetadataKeyOriginalReleaseYear", "AVFoundation")]
	public static NSString ID3MetadataKeyOriginalReleaseYear
	{
		get
		{
			if (_ID3MetadataKeyOriginalReleaseYear == null)
			{
				_ID3MetadataKeyOriginalReleaseYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOriginalReleaseYear");
			}
			return _ID3MetadataKeyOriginalReleaseYear;
		}
	}

	[Field("AVMetadataID3MetadataKeyFileOwner", "AVFoundation")]
	public static NSString ID3MetadataKeyFileOwner
	{
		get
		{
			if (_ID3MetadataKeyFileOwner == null)
			{
				_ID3MetadataKeyFileOwner = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyFileOwner");
			}
			return _ID3MetadataKeyFileOwner;
		}
	}

	[Field("AVMetadataID3MetadataKeyLeadPerformer", "AVFoundation")]
	public static NSString ID3MetadataKeyLeadPerformer
	{
		get
		{
			if (_ID3MetadataKeyLeadPerformer == null)
			{
				_ID3MetadataKeyLeadPerformer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyLeadPerformer");
			}
			return _ID3MetadataKeyLeadPerformer;
		}
	}

	[Field("AVMetadataID3MetadataKeyBand", "AVFoundation")]
	public static NSString ID3MetadataKeyBand
	{
		get
		{
			if (_ID3MetadataKeyBand == null)
			{
				_ID3MetadataKeyBand = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyBand");
			}
			return _ID3MetadataKeyBand;
		}
	}

	[Field("AVMetadataID3MetadataKeyConductor", "AVFoundation")]
	public static NSString ID3MetadataKeyConductor
	{
		get
		{
			if (_ID3MetadataKeyConductor == null)
			{
				_ID3MetadataKeyConductor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyConductor");
			}
			return _ID3MetadataKeyConductor;
		}
	}

	[Field("AVMetadataID3MetadataKeyModifiedBy", "AVFoundation")]
	public static NSString ID3MetadataKeyModifiedBy
	{
		get
		{
			if (_ID3MetadataKeyModifiedBy == null)
			{
				_ID3MetadataKeyModifiedBy = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyModifiedBy");
			}
			return _ID3MetadataKeyModifiedBy;
		}
	}

	[Field("AVMetadataID3MetadataKeyPartOfASet", "AVFoundation")]
	public static NSString ID3MetadataKeyPartOfASet
	{
		get
		{
			if (_ID3MetadataKeyPartOfASet == null)
			{
				_ID3MetadataKeyPartOfASet = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPartOfASet");
			}
			return _ID3MetadataKeyPartOfASet;
		}
	}

	[Field("AVMetadataID3MetadataKeyProducedNotice", "AVFoundation")]
	public static NSString ID3MetadataKeyProducedNotice
	{
		get
		{
			if (_ID3MetadataKeyProducedNotice == null)
			{
				_ID3MetadataKeyProducedNotice = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyProducedNotice");
			}
			return _ID3MetadataKeyProducedNotice;
		}
	}

	[Field("AVMetadataID3MetadataKeyPublisher", "AVFoundation")]
	public static NSString ID3MetadataKeyPublisher
	{
		get
		{
			if (_ID3MetadataKeyPublisher == null)
			{
				_ID3MetadataKeyPublisher = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPublisher");
			}
			return _ID3MetadataKeyPublisher;
		}
	}

	[Field("AVMetadataID3MetadataKeyTrackNumber", "AVFoundation")]
	public static NSString ID3MetadataKeyTrackNumber
	{
		get
		{
			if (_ID3MetadataKeyTrackNumber == null)
			{
				_ID3MetadataKeyTrackNumber = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTrackNumber");
			}
			return _ID3MetadataKeyTrackNumber;
		}
	}

	[Field("AVMetadataID3MetadataKeyRecordingDates", "AVFoundation")]
	public static NSString ID3MetadataKeyRecordingDates
	{
		get
		{
			if (_ID3MetadataKeyRecordingDates == null)
			{
				_ID3MetadataKeyRecordingDates = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyRecordingDates");
			}
			return _ID3MetadataKeyRecordingDates;
		}
	}

	[Field("AVMetadataID3MetadataKeyInternetRadioStationName", "AVFoundation")]
	public static NSString ID3MetadataKeyInternetRadioStationName
	{
		get
		{
			if (_ID3MetadataKeyInternetRadioStationName == null)
			{
				_ID3MetadataKeyInternetRadioStationName = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternetRadioStationName");
			}
			return _ID3MetadataKeyInternetRadioStationName;
		}
	}

	[Field("AVMetadataID3MetadataKeyInternetRadioStationOwner", "AVFoundation")]
	public static NSString ID3MetadataKeyInternetRadioStationOwner
	{
		get
		{
			if (_ID3MetadataKeyInternetRadioStationOwner == null)
			{
				_ID3MetadataKeyInternetRadioStationOwner = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternetRadioStationOwner");
			}
			return _ID3MetadataKeyInternetRadioStationOwner;
		}
	}

	[Field("AVMetadataID3MetadataKeySize", "AVFoundation")]
	public static NSString ID3MetadataKeySize
	{
		get
		{
			if (_ID3MetadataKeySize == null)
			{
				_ID3MetadataKeySize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySize");
			}
			return _ID3MetadataKeySize;
		}
	}

	[Field("AVMetadataID3MetadataKeyAlbumSortOrder", "AVFoundation")]
	public static NSString ID3MetadataKeyAlbumSortOrder
	{
		get
		{
			if (_ID3MetadataKeyAlbumSortOrder == null)
			{
				_ID3MetadataKeyAlbumSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyAlbumSortOrder");
			}
			return _ID3MetadataKeyAlbumSortOrder;
		}
	}

	[Field("AVMetadataID3MetadataKeyPerformerSortOrder", "AVFoundation")]
	public static NSString ID3MetadataKeyPerformerSortOrder
	{
		get
		{
			if (_ID3MetadataKeyPerformerSortOrder == null)
			{
				_ID3MetadataKeyPerformerSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPerformerSortOrder");
			}
			return _ID3MetadataKeyPerformerSortOrder;
		}
	}

	[Field("AVMetadataID3MetadataKeyTitleSortOrder", "AVFoundation")]
	public static NSString ID3MetadataKeyTitleSortOrder
	{
		get
		{
			if (_ID3MetadataKeyTitleSortOrder == null)
			{
				_ID3MetadataKeyTitleSortOrder = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTitleSortOrder");
			}
			return _ID3MetadataKeyTitleSortOrder;
		}
	}

	[Field("AVMetadataID3MetadataKeyInternationalStandardRecordingCode", "AVFoundation")]
	public static NSString ID3MetadataKeyInternationalStandardRecordingCode
	{
		get
		{
			if (_ID3MetadataKeyInternationalStandardRecordingCode == null)
			{
				_ID3MetadataKeyInternationalStandardRecordingCode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyInternationalStandardRecordingCode");
			}
			return _ID3MetadataKeyInternationalStandardRecordingCode;
		}
	}

	[Field("AVMetadataID3MetadataKeyEncodedWith", "AVFoundation")]
	public static NSString ID3MetadataKeyEncodedWith
	{
		get
		{
			if (_ID3MetadataKeyEncodedWith == null)
			{
				_ID3MetadataKeyEncodedWith = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyEncodedWith");
			}
			return _ID3MetadataKeyEncodedWith;
		}
	}

	[Field("AVMetadataID3MetadataKeySetSubtitle", "AVFoundation")]
	public static NSString ID3MetadataKeySetSubtitle
	{
		get
		{
			if (_ID3MetadataKeySetSubtitle == null)
			{
				_ID3MetadataKeySetSubtitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeySetSubtitle");
			}
			return _ID3MetadataKeySetSubtitle;
		}
	}

	[Field("AVMetadataID3MetadataKeyYear", "AVFoundation")]
	public static NSString ID3MetadataKeyYear
	{
		get
		{
			if (_ID3MetadataKeyYear == null)
			{
				_ID3MetadataKeyYear = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyYear");
			}
			return _ID3MetadataKeyYear;
		}
	}

	[Field("AVMetadataID3MetadataKeyUserText", "AVFoundation")]
	public static NSString ID3MetadataKeyUserText
	{
		get
		{
			if (_ID3MetadataKeyUserText == null)
			{
				_ID3MetadataKeyUserText = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUserText");
			}
			return _ID3MetadataKeyUserText;
		}
	}

	[Field("AVMetadataID3MetadataKeyUniqueFileIdentifier", "AVFoundation")]
	public static NSString ID3MetadataKeyUniqueFileIdentifier
	{
		get
		{
			if (_ID3MetadataKeyUniqueFileIdentifier == null)
			{
				_ID3MetadataKeyUniqueFileIdentifier = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUniqueFileIdentifier");
			}
			return _ID3MetadataKeyUniqueFileIdentifier;
		}
	}

	[Field("AVMetadataID3MetadataKeyTermsOfUse", "AVFoundation")]
	public static NSString ID3MetadataKeyTermsOfUse
	{
		get
		{
			if (_ID3MetadataKeyTermsOfUse == null)
			{
				_ID3MetadataKeyTermsOfUse = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyTermsOfUse");
			}
			return _ID3MetadataKeyTermsOfUse;
		}
	}

	[Field("AVMetadataID3MetadataKeyUnsynchronizedLyric", "AVFoundation")]
	public static NSString ID3MetadataKeyUnsynchronizedLyric
	{
		get
		{
			if (_ID3MetadataKeyUnsynchronizedLyric == null)
			{
				_ID3MetadataKeyUnsynchronizedLyric = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUnsynchronizedLyric");
			}
			return _ID3MetadataKeyUnsynchronizedLyric;
		}
	}

	[Field("AVMetadataID3MetadataKeyCommercialInformation", "AVFoundation")]
	public static NSString ID3MetadataKeyCommercialInformation
	{
		get
		{
			if (_ID3MetadataKeyCommercialInformation == null)
			{
				_ID3MetadataKeyCommercialInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCommercialInformation");
			}
			return _ID3MetadataKeyCommercialInformation;
		}
	}

	[Field("AVMetadataID3MetadataKeyCopyrightInformation", "AVFoundation")]
	public static NSString ID3MetadataKeyCopyrightInformation
	{
		get
		{
			if (_ID3MetadataKeyCopyrightInformation == null)
			{
				_ID3MetadataKeyCopyrightInformation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyCopyrightInformation");
			}
			return _ID3MetadataKeyCopyrightInformation;
		}
	}

	[Field("AVMetadataID3MetadataKeyOfficialAudioFileWebpage", "AVFoundation")]
	public static NSString ID3MetadataKeyOfficialAudioFileWebpage
	{
		get
		{
			if (_ID3MetadataKeyOfficialAudioFileWebpage == null)
			{
				_ID3MetadataKeyOfficialAudioFileWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialAudioFileWebpage");
			}
			return _ID3MetadataKeyOfficialAudioFileWebpage;
		}
	}

	[Field("AVMetadataID3MetadataKeyOfficialArtistWebpage", "AVFoundation")]
	public static NSString ID3MetadataKeyOfficialArtistWebpage
	{
		get
		{
			if (_ID3MetadataKeyOfficialArtistWebpage == null)
			{
				_ID3MetadataKeyOfficialArtistWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialArtistWebpage");
			}
			return _ID3MetadataKeyOfficialArtistWebpage;
		}
	}

	[Field("AVMetadataID3MetadataKeyOfficialAudioSourceWebpage", "AVFoundation")]
	public static NSString ID3MetadataKeyOfficialAudioSourceWebpage
	{
		get
		{
			if (_ID3MetadataKeyOfficialAudioSourceWebpage == null)
			{
				_ID3MetadataKeyOfficialAudioSourceWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialAudioSourceWebpage");
			}
			return _ID3MetadataKeyOfficialAudioSourceWebpage;
		}
	}

	[Field("AVMetadataID3MetadataKeyOfficialInternetRadioStationHomepage", "AVFoundation")]
	public static NSString ID3MetadataKeyOfficialInternetRadioStationHomepage
	{
		get
		{
			if (_ID3MetadataKeyOfficialInternetRadioStationHomepage == null)
			{
				_ID3MetadataKeyOfficialInternetRadioStationHomepage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialInternetRadioStationHomepage");
			}
			return _ID3MetadataKeyOfficialInternetRadioStationHomepage;
		}
	}

	[Field("AVMetadataID3MetadataKeyPayment", "AVFoundation")]
	public static NSString ID3MetadataKeyPayment
	{
		get
		{
			if (_ID3MetadataKeyPayment == null)
			{
				_ID3MetadataKeyPayment = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyPayment");
			}
			return _ID3MetadataKeyPayment;
		}
	}

	[Field("AVMetadataID3MetadataKeyOfficialPublisherWebpage", "AVFoundation")]
	public static NSString ID3MetadataKeyOfficialPublisherWebpage
	{
		get
		{
			if (_ID3MetadataKeyOfficialPublisherWebpage == null)
			{
				_ID3MetadataKeyOfficialPublisherWebpage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyOfficialPublisherWebpage");
			}
			return _ID3MetadataKeyOfficialPublisherWebpage;
		}
	}

	[Field("AVMetadataID3MetadataKeyUserURL", "AVFoundation")]
	public static NSString ID3MetadataKeyUserURL
	{
		get
		{
			if (_ID3MetadataKeyUserURL == null)
			{
				_ID3MetadataKeyUserURL = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataID3MetadataKeyUserURL");
			}
			return _ID3MetadataKeyUserURL;
		}
	}
}
