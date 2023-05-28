using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSMetadataItem", true)]
public class NSMetadataItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttribute_ = "valueForAttribute:";

	private static readonly IntPtr selValueForAttribute_Handle = Selector.GetHandle("valueForAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValuesForAttributes_ = "valuesForAttributes:";

	private static readonly IntPtr selValuesForAttributes_Handle = Selector.GetHandle("valuesForAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMetadataItem");

	public NSString FileSystemName => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.ItemFSNameKey));

	public NSString DisplayName => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.ItemDisplayNameKey));

	public NSUrl Url => Runtime.GetNSObject<NSUrl>(GetHandle(NSMetadataQuery.ItemURLKey));

	public NSString Path => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.ItemPathKey));

	public NSNumber FileSystemSize => Runtime.GetNSObject<NSNumber>(GetHandle(NSMetadataQuery.ItemFSSizeKey));

	public NSDate FileSystemCreationDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.ItemFSCreationDateKey));

	public NSDate FileSystemContentChangeDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.ItemFSContentChangeDateKey));

	[iOS(8, 0)]
	[Mac(10, 9)]
	public NSString ContentType => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.ContentTypeKey));

	[iOS(8, 0)]
	[Mac(10, 9)]
	public NSString[] ContentTypeTree
	{
		get
		{
			using NSArray weakArray = Runtime.GetNSObject<NSArray>(GetHandle(NSMetadataQuery.ContentTypeTreeKey));
			return NSArray.FromArray<NSString>(weakArray);
		}
	}

	public bool IsUbiquitous => GetBool(NSMetadataQuery.ItemIsUbiquitousKey);

	public bool UbiquitousItemHasUnresolvedConflicts => GetBool(NSMetadataQuery.UbiquitousItemHasUnresolvedConflictsKey);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public NSItemDownloadingStatus DownloadingStatus => NSItemDownloadingStatusExtensions.GetValue(Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.UbiquitousItemDownloadingStatusKey)));

	public bool UbiquitousItemIsDownloading => GetBool(NSMetadataQuery.UbiquitousItemIsDownloadingKey);

	public bool UbiquitousItemIsUploaded => GetBool(NSMetadataQuery.UbiquitousItemIsUploadedKey);

	public bool UbiquitousItemIsUploading => GetBool(NSMetadataQuery.UbiquitousItemIsUploadingKey);

	public double UbiquitousItemPercentDownloaded => GetDouble(NSMetadataQuery.UbiquitousItemPercentDownloadedKey);

	public double UbiquitousItemPercentUploaded => GetDouble(NSMetadataQuery.UbiquitousItemPercentUploadedKey);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public NSError UbiquitousItemDownloadingError => Runtime.GetNSObject<NSError>(GetHandle(NSMetadataQuery.UbiquitousItemDownloadingErrorKey));

	[iOS(7, 0)]
	[Mac(10, 9)]
	public NSError UbiquitousItemUploadingError => Runtime.GetNSObject<NSError>(GetHandle(NSMetadataQuery.UbiquitousItemUploadingErrorKey));

	[iOS(8, 0)]
	[Mac(10, 10)]
	public bool UbiquitousItemDownloadRequested => GetBool(NSMetadataQuery.UbiquitousItemDownloadRequestedKey);

	[iOS(8, 0)]
	[Mac(10, 10)]
	public bool UbiquitousItemIsExternalDocument => GetBool(NSMetadataQuery.UbiquitousItemIsExternalDocumentKey);

	[iOS(8, 0)]
	[Mac(10, 9)]
	public NSString UbiquitousItemContainerDisplayName => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.UbiquitousItemContainerDisplayNameKey));

	[iOS(8, 0)]
	[Mac(10, 9)]
	public NSUrl UbiquitousItemUrlInLocalContainer => Runtime.GetNSObject<NSUrl>(GetHandle(NSMetadataQuery.UbiquitousItemURLInLocalContainerKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Keywords => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.KeywordsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Title => NSString.FromHandle(GetHandle(NSMetadataQuery.TitleKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Authors => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.AuthorsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Editors => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.EditorsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Participants => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ParticipantsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Projects => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ProjectsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate DownloadedDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.DownloadedDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] WhereFroms => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.WhereFromsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Comment => NSString.FromHandle(GetHandle(NSMetadataQuery.CommentKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Copyright => NSString.FromHandle(GetHandle(NSMetadataQuery.CopyrightKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate LastUsedDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.LastUsedDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate ContentCreationDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.ContentCreationDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate ContentModificationDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.ContentModificationDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate DateAdded => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.DateAddedKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? DurationSeconds => GetNullableDouble(NSMetadataQuery.DurationSecondsKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] ContactKeywords => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ContactKeywordsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Version => NSString.FromHandle(GetHandle(NSMetadataQuery.VersionKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? PixelHeight => GetNInt(NSMetadataQuery.PixelHeightKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? PixelWidth => GetNInt(NSMetadataQuery.PixelWidthKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? PixelCount => GetNInt(NSMetadataQuery.PixelCountKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ColorSpace => NSString.FromHandle(GetHandle(NSMetadataQuery.ColorSpaceKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? BitsPerSample => GetNInt(NSMetadataQuery.BitsPerSampleKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? FlashOnOff => GetNullableBool(NSMetadataQuery.FlashOnOffKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? FocalLength => GetNullableDouble(NSMetadataQuery.FocalLengthKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AcquisitionMake => NSString.FromHandle(GetHandle(NSMetadataQuery.AcquisitionMakeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AcquisitionModel => NSString.FromHandle(GetHandle(NSMetadataQuery.AcquisitionModelKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? IsoSpeed => GetNullableDouble(NSMetadataQuery.IsoSpeedKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? Orientation => GetNInt(NSMetadataQuery.OrientationKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] LayerNames => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.LayerNamesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? WhiteBalance => GetNullableDouble(NSMetadataQuery.WhiteBalanceKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Aperture => GetNullableDouble(NSMetadataQuery.ApertureKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ProfileName => NSString.FromHandle(GetHandle(NSMetadataQuery.ProfileNameKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? ResolutionWidthDpi => GetNInt(NSMetadataQuery.ResolutionWidthDpiKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? ResolutionHeightDpi => GetNInt(NSMetadataQuery.ResolutionHeightDpiKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? ExposureMode => GetNInt(NSMetadataQuery.ExposureModeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? ExposureTimeSeconds => GetNullableDouble(NSMetadataQuery.ExposureTimeSecondsKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ExifVersion => NSString.FromHandle(GetHandle(NSMetadataQuery.ExifVersionKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string CameraOwner => NSString.FromHandle(GetHandle(NSMetadataQuery.CameraOwnerKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? FocalLength35mm => GetNInt(NSMetadataQuery.FocalLength35mmKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string LensModel => NSString.FromHandle(GetHandle(NSMetadataQuery.LensModelKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ExifGpsVersion => NSString.FromHandle(GetHandle(NSMetadataQuery.ExifGpsVersionKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Altitude => GetNullableDouble(NSMetadataQuery.AltitudeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Latitude => GetNullableDouble(NSMetadataQuery.LatitudeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Longitude => GetNullableDouble(NSMetadataQuery.LongitudeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Speed => GetNullableDouble(NSMetadataQuery.SpeedKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate Timestamp => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.TimestampKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsTrack => GetNullableDouble(NSMetadataQuery.GpsTrackKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? ImageDirection => GetNullableDouble(NSMetadataQuery.ImageDirectionKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string NamedLocation => NSString.FromHandle(GetHandle(NSMetadataQuery.NamedLocationKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string GpsStatus => NSString.FromHandle(GetHandle(NSMetadataQuery.GpsStatusKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string GpsMeasureMode => NSString.FromHandle(GetHandle(NSMetadataQuery.GpsMeasureModeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDop => GetNullableDouble(NSMetadataQuery.GpsDopKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string GpsMapDatum => NSString.FromHandle(GetHandle(NSMetadataQuery.GpsMapDatumKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDestLatitude => GetNullableDouble(NSMetadataQuery.GpsDestLatitudeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDestLongitude => GetNullableDouble(NSMetadataQuery.GpsDestLongitudeKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDestBearing => GetNullableDouble(NSMetadataQuery.GpsDestBearingKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDestDistance => GetNullableDouble(NSMetadataQuery.GpsDestDistanceKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string GpsProcessingMethod => NSString.FromHandle(GetHandle(NSMetadataQuery.GpsProcessingMethodKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string GpsAreaInformation => NSString.FromHandle(GetHandle(NSMetadataQuery.GpsAreaInformationKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate GpsDateStamp => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.GpsDateStampKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? GpsDifferental => GetNullableDouble(NSMetadataQuery.GpsDifferentalKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Codecs => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.CodecsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] MediaTypes => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.MediaTypesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? Streamable => GetNullableBool(NSMetadataQuery.StreamableKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? TotalBitRate => GetNInt(NSMetadataQuery.TotalBitRateKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? VideoBitRate => GetNInt(NSMetadataQuery.VideoBitRateKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? AudioBitRate => GetNInt(NSMetadataQuery.AudioBitRateKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string DeliveryType => NSString.FromHandle(GetHandle(NSMetadataQuery.DeliveryTypeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Album => NSString.FromHandle(GetHandle(NSMetadataQuery.AlbumKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? HasAlphaChannel => GetNullableBool(NSMetadataQuery.HasAlphaChannelKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? RedEyeOnOff => GetNullableBool(NSMetadataQuery.RedEyeOnOffKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string MeteringMode => NSString.FromHandle(GetHandle(NSMetadataQuery.MeteringModeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? MaxAperture => GetNullableDouble(NSMetadataQuery.MaxApertureKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? FNumber => GetNInt(NSMetadataQuery.FNumberKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ExposureProgram => NSString.FromHandle(GetHandle(NSMetadataQuery.ExposureProgramKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ExposureTimeString => NSString.FromHandle(GetHandle(NSMetadataQuery.ExposureTimeStringKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Headline => NSString.FromHandle(GetHandle(NSMetadataQuery.HeadlineKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Instructions => NSString.FromHandle(GetHandle(NSMetadataQuery.InstructionsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string City => NSString.FromHandle(GetHandle(NSMetadataQuery.CityKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string StateOrProvince => NSString.FromHandle(GetHandle(NSMetadataQuery.StateOrProvinceKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Country => NSString.FromHandle(GetHandle(NSMetadataQuery.CountryKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string TextContent => NSString.FromHandle(GetHandle(NSMetadataQuery.TextContentKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? AudioSampleRate => GetNInt(NSMetadataQuery.AudioSampleRateKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? AudioChannelCount => GetNInt(NSMetadataQuery.AudioChannelCountKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? Tempo => GetNullableDouble(NSMetadataQuery.TempoKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string KeySignature => NSString.FromHandle(GetHandle(NSMetadataQuery.KeySignatureKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string TimeSignature => NSString.FromHandle(GetHandle(NSMetadataQuery.TimeSignatureKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AudioEncodingApplication => NSString.FromHandle(GetHandle(NSMetadataQuery.AudioEncodingApplicationKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Composer => NSString.FromHandle(GetHandle(NSMetadataQuery.ComposerKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Lyricist => NSString.FromHandle(GetHandle(NSMetadataQuery.LyricistKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? AudioTrackNumber => GetNInt(NSMetadataQuery.AudioTrackNumberKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate RecordingDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.RecordingDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string MusicalGenre => NSString.FromHandle(GetHandle(NSMetadataQuery.MusicalGenreKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? IsGeneralMidiSequence => GetNullableBool(NSMetadataQuery.IsGeneralMidiSequenceKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? RecordingYear => GetNInt(NSMetadataQuery.RecordingYearKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Organizations => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.OrganizationsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Languages => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.LanguagesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Rights => NSString.FromHandle(GetHandle(NSMetadataQuery.RightsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Publishers => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.PublishersKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Contributors => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ContributorsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Coverage => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.CoverageKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Subject => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.SubjectKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Theme => Runtime.GetNSObject<NSString>(GetHandle(NSMetadataQuery.ThemeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public new string Description => NSString.FromHandle(GetHandle(NSMetadataQuery.DescriptionKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Identifier => NSString.FromHandle(GetHandle(NSMetadataQuery.IdentifierKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Audiences => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.AudiencesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public nint? NumberOfPages => GetNInt(NSMetadataQuery.NumberOfPagesKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? PageWidth => GetNullableDouble(NSMetadataQuery.PageWidthKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? PageHeight => GetNullableDouble(NSMetadataQuery.PageHeightKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string SecurityMethod => NSString.FromHandle(GetHandle(NSMetadataQuery.SecurityMethodKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Creator => NSString.FromHandle(GetHandle(NSMetadataQuery.CreatorKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] EncodingApplications => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.EncodingApplicationsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public NSDate DueDate => Runtime.GetNSObject<NSDate>(GetHandle(NSMetadataQuery.DueDateKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public double? StarRating => GetNullableDouble(NSMetadataQuery.StarRatingKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] PhoneNumbers => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.PhoneNumbersKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] EmailAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.EmailAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] InstantMessageAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.InstantMessageAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Kind => NSString.FromHandle(GetHandle(NSMetadataQuery.KindKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Recipients => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.RecipientsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string FinderComment => NSString.FromHandle(GetHandle(NSMetadataQuery.FinderCommentKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Fonts => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.FontsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AppleLoopsRoot => NSString.FromHandle(GetHandle(NSMetadataQuery.AppleLoopsRootKeyKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AppleLoopsKeyFilterType => NSString.FromHandle(GetHandle(NSMetadataQuery.AppleLoopsKeyFilterTypeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string AppleLoopsLoopMode => NSString.FromHandle(GetHandle(NSMetadataQuery.AppleLoopsLoopModeKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] AppleLoopDescriptors => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.AppleLoopDescriptorsKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string MusicalInstrumentCategory => NSString.FromHandle(GetHandle(NSMetadataQuery.MusicalInstrumentCategoryKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string MusicalInstrumentName => NSString.FromHandle(GetHandle(NSMetadataQuery.MusicalInstrumentNameKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string CFBundleIdentifier => NSString.FromHandle(GetHandle(NSMetadataQuery.CFBundleIdentifierKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Information => NSString.FromHandle(GetHandle(NSMetadataQuery.InformationKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Director => NSString.FromHandle(GetHandle(NSMetadataQuery.DirectorKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Producer => NSString.FromHandle(GetHandle(NSMetadataQuery.ProducerKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string Genre => NSString.FromHandle(GetHandle(NSMetadataQuery.GenreKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] Performers => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.PerformersKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string OriginalFormat => NSString.FromHandle(GetHandle(NSMetadataQuery.OriginalFormatKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string OriginalSource => NSString.FromHandle(GetHandle(NSMetadataQuery.OriginalSourceKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] AuthorEmailAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.AuthorEmailAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] RecipientEmailAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.RecipientEmailAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] AuthorAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.AuthorAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] RecipientAddresses => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.RecipientAddressesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? IsLikelyJunk => GetNullableBool(NSMetadataQuery.IsLikelyJunkKey);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] ExecutableArchitectures => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ExecutableArchitecturesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string ExecutablePlatform => NSString.FromHandle(GetHandle(NSMetadataQuery.ExecutablePlatformKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public string[] ApplicationCategories => NSArray.StringArrayFromHandle(GetHandle(NSMetadataQuery.ApplicationCategoriesKey));

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 9)]
	public bool? IsApplicationManaged => GetNullableBool(NSMetadataQuery.IsApplicationManagedKey);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	private bool GetBool(NSString key)
	{
		return Runtime.GetNSObject<NSNumber>(GetHandle(key))?.BoolValue ?? false;
	}

	private bool? GetNullableBool(NSString key)
	{
		return Runtime.GetNSObject<NSNumber>(GetHandle(key))?.BoolValue;
	}

	private double GetDouble(NSString key)
	{
		return Runtime.GetNSObject<NSNumber>(GetHandle(key))?.DoubleValue ?? 0.0;
	}

	private double? GetNullableDouble(NSString key)
	{
		return Runtime.GetNSObject<NSNumber>(GetHandle(key))?.DoubleValue;
	}

	private nint? GetNInt(NSString key)
	{
		return Runtime.GetNSObject<NSNumber>(GetHandle(key))?.NIntValue;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataItem()
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
	protected NSMetadataItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMetadataItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMetadataItem(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr GetHandle(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttribute_Handle, key.Handle);
	}

	[Export("valueForAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueForAttribute(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttribute_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttribute_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("valuesForAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ValuesForAttributes(NSArray keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValuesForAttributes_Handle, keys.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValuesForAttributes_Handle, keys.Handle));
	}
}
