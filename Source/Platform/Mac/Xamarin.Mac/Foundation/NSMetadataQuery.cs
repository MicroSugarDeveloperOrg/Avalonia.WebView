using System.ComponentModel;
using AppKit;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSMetadataQuery", true)]
public class NSMetadataQuery : NSObject
{
	[Register]
	internal class _NSMetadataQueryDelegate : NSObject, INSMetadataQueryDelegate, INativeObject, IDisposable
	{
		internal NSMetadataQueryObject? replacementObjectForResultObject;

		internal NSMetadataQueryValue? replacementValueForAttributevalue;

		public _NSMetadataQueryDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("metadataQuery:replacementObjectForResultObject:")]
		public NSObject ReplacementObjectForResultObject(NSMetadataQuery query, NSMetadataItem result)
		{
			return replacementObjectForResultObject?.Invoke(query, result);
		}

		[Preserve(Conditional = true)]
		[Export("metadataQuery:replacementValueForAttribute:value:")]
		public NSObject ReplacementValueForAttributevalue(NSMetadataQuery query, string attributeName, NSObject value)
		{
			return replacementValueForAttributevalue?.Invoke(query, attributeName, value);
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveDidFinishGathering(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidFinishGatheringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidFinishGathering(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidFinishGatheringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidStartGathering(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartGatheringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidStartGathering(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartGatheringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUpdate(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUpdate(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveGatheringProgress(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(GatheringProgressNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveGatheringProgress(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(GatheringProgressNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableUpdates = "disableUpdates";

	private static readonly IntPtr selDisableUpdatesHandle = Selector.GetHandle("disableUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableUpdates = "enableUpdates";

	private static readonly IntPtr selEnableUpdatesHandle = Selector.GetHandle("enableUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateResultsUsingBlock_ = "enumerateResultsUsingBlock:";

	private static readonly IntPtr selEnumerateResultsUsingBlock_Handle = Selector.GetHandle("enumerateResultsUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateResultsWithOptions_UsingBlock_ = "enumerateResultsWithOptions:usingBlock:";

	private static readonly IntPtr selEnumerateResultsWithOptions_UsingBlock_Handle = Selector.GetHandle("enumerateResultsWithOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupedResults = "groupedResults";

	private static readonly IntPtr selGroupedResultsHandle = Selector.GetHandle("groupedResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupingAttributes = "groupingAttributes";

	private static readonly IntPtr selGroupingAttributesHandle = Selector.GetHandle("groupingAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfResult_ = "indexOfResult:";

	private static readonly IntPtr selIndexOfResult_Handle = Selector.GetHandle("indexOfResult:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGathering = "isGathering";

	private static readonly IntPtr selIsGatheringHandle = Selector.GetHandle("isGathering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStarted = "isStarted";

	private static readonly IntPtr selIsStartedHandle = Selector.GetHandle("isStarted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStopped = "isStopped";

	private static readonly IntPtr selIsStoppedHandle = Selector.GetHandle("isStopped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationBatchingInterval = "notificationBatchingInterval";

	private static readonly IntPtr selNotificationBatchingIntervalHandle = Selector.GetHandle("notificationBatchingInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperationQueue = "operationQueue";

	private static readonly IntPtr selOperationQueueHandle = Selector.GetHandle("operationQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultAtIndex_ = "resultAtIndex:";

	private static readonly IntPtr selResultAtIndex_Handle = Selector.GetHandle("resultAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultCount = "resultCount";

	private static readonly IntPtr selResultCountHandle = Selector.GetHandle("resultCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResults = "results";

	private static readonly IntPtr selResultsHandle = Selector.GetHandle("results");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchItems = "searchItems";

	private static readonly IntPtr selSearchItemsHandle = Selector.GetHandle("searchItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchScopes = "searchScopes";

	private static readonly IntPtr selSearchScopesHandle = Selector.GetHandle("searchScopes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupingAttributes_ = "setGroupingAttributes:";

	private static readonly IntPtr selSetGroupingAttributes_Handle = Selector.GetHandle("setGroupingAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotificationBatchingInterval_ = "setNotificationBatchingInterval:";

	private static readonly IntPtr selSetNotificationBatchingInterval_Handle = Selector.GetHandle("setNotificationBatchingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOperationQueue_ = "setOperationQueue:";

	private static readonly IntPtr selSetOperationQueue_Handle = Selector.GetHandle("setOperationQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchItems_ = "setSearchItems:";

	private static readonly IntPtr selSetSearchItems_Handle = Selector.GetHandle("setSearchItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchScopes_ = "setSearchScopes:";

	private static readonly IntPtr selSetSearchScopes_Handle = Selector.GetHandle("setSearchScopes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueListAttributes_ = "setValueListAttributes:";

	private static readonly IntPtr selSetValueListAttributes_Handle = Selector.GetHandle("setValueListAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartQuery = "startQuery";

	private static readonly IntPtr selStartQueryHandle = Selector.GetHandle("startQuery");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopQuery = "stopQuery";

	private static readonly IntPtr selStopQueryHandle = Selector.GetHandle("stopQuery");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueListAttributes = "valueListAttributes";

	private static readonly IntPtr selValueListAttributesHandle = Selector.GetHandle("valueListAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueLists = "valueLists";

	private static readonly IntPtr selValueListsHandle = Selector.GetHandle("valueLists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueOfAttribute_ForResultAtIndex_ = "valueOfAttribute:forResultAtIndex:";

	private static readonly IntPtr selValueOfAttribute_ForResultAtIndex_Handle = Selector.GetHandle("valueOfAttribute:forResultAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMetadataQuery");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccessibleUbiquitousExternalDocumentsScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AcquisitionMakeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AcquisitionModelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AltitudeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleLoopDescriptorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleLoopsKeyFilterTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleLoopsLoopModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleLoopsRootKeyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationCategoriesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudiencesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioChannelCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioEncodingApplicationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioSampleRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioTrackNumberKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthorAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthorEmailAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BitsPerSampleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CFBundleIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraOwnerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSpaceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CommentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ComposerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContactKeywordsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentCreationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentModificationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentTypeTreeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContributorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CopyrightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CountryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CoverageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DateAddedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeliveryTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidFinishGatheringNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidStartGatheringNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUpdateNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DirectorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownloadedDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DueDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DurationSecondsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EditorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmailAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncodingApplicationsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExecutableArchitecturesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExecutablePlatformKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifGpsVersionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifVersionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExposureModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExposureProgramKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExposureTimeSecondsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExposureTimeStringKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FNumberKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FinderCommentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FlashOnOffKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocalLength35mmKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocalLengthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GatheringProgressNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenreKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsAreaInformationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDateStampKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDestBearingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDestDistanceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDestLatitudeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDestLongitudeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDifferentalKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsDopKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsMapDatumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsMeasureModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsProcessingMethodKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsStatusKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpsTrackKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasAlphaChannelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeadlineKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageDirectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InformationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InstantMessageAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InstructionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsApplicationManagedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsGeneralMidiSequenceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsLikelyJunkKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsoSpeedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemDisplayNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFSContentChangeDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFSCreationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFSNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFSSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemIsUbiquitousKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemPathKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeySignatureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeywordsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KindKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LanguagesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LastUsedDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LatitudeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayerNamesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LensModelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalComputerScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalDocumentsScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LongitudeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LyricistKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaTypesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MeteringModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MusicalGenreKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MusicalInstrumentCategoryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MusicalInstrumentNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NamedLocationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NumberOfPagesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrganizationsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrientationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OriginalFormatKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OriginalSourceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PageHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PageWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ParticipantsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PerformersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhoneNumbersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProducerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProjectsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PublishersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QueryUpdateAddedItemsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QueryUpdateChangedItemsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QueryUpdateRemovedItemsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecipientAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecipientEmailAddressesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecipientsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordingDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordingYearKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RedEyeOnOffKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResolutionHeightDpiKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResolutionWidthDpiKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultContentRelevanceAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RightsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SecurityMethodKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SpeedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StarRatingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StateOrProvinceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StreamableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubjectKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TempoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextContentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThemeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeSignatureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimestampKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TotalBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousDataScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousDocumentsScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemContainerDisplayNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadRequestedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingStatusKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemHasUnresolvedConflictsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsDownloadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsDownloadingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsExternalDocumentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsSharedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsUploadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsUploadingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemPercentDownloadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemPercentUploadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemURLInLocalContainerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemUploadingErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemCurrentUserPermissionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemCurrentUserRoleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemMostRecentEditorNameComponentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemOwnerNameComponentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemPermissionsReadOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemPermissionsReadWrite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemRoleOwner;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemRoleParticipant;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserHomeScope;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VersionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VideoBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WhereFromsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WhiteBalanceKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSMetadataQueryDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSMetadataQueryDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] GroupedResults
	{
		[Export("groupedResults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupedResultsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupedResultsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray GroupingAttributes
	{
		[Export("groupingAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupingAttributesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupingAttributesHandle));
		}
		[Export("setGroupingAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupingAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupingAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsGathering
	{
		[Export("isGathering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGatheringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGatheringHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsStarted
	{
		[Export("isStarted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStartedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStartedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsStopped
	{
		[Export("isStopped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStoppedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStoppedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double NotificationBatchingInterval
	{
		[Export("notificationBatchingInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selNotificationBatchingIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selNotificationBatchingIntervalHandle);
		}
		[Export("setNotificationBatchingInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetNotificationBatchingInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetNotificationBatchingInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSOperationQueue? OperationQueue
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("operationQueue", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperationQueueHandle));
			}
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperationQueueHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setOperationQueue:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOperationQueue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOperationQueue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ResultCount
	{
		[Export("resultCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selResultCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selResultCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMetadataItem[] Results
	{
		[Export("results")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultsHandle));
			}
			return NSArray.ArrayFromHandle<NSMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSObject[]? SearchItems
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("searchItems", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchItemsHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setSearchItems:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchItems_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchItems_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] SearchScopes
	{
		[Export("searchScopes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchScopesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchScopesHandle));
		}
		[Export("setSearchScopes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchScopes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchScopes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ValueListAttributes
	{
		[Export("valueListAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueListAttributesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueListAttributesHandle));
		}
		[Export("setValueListAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueListAttributes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueListAttributes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ValueLists
	{
		[Export("valueLists")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueListsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueListsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AccessibleUbiquitousExternalDocumentsScope
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AccessibleUbiquitousExternalDocumentsScope == null)
			{
				_AccessibleUbiquitousExternalDocumentsScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope");
			}
			return _AccessibleUbiquitousExternalDocumentsScope;
		}
	}

	[Field("NSMetadataItemAcquisitionMakeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AcquisitionMakeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AcquisitionMakeKey == null)
			{
				_AcquisitionMakeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAcquisitionMakeKey");
			}
			return _AcquisitionMakeKey;
		}
	}

	[Field("NSMetadataItemAcquisitionModelKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AcquisitionModelKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AcquisitionModelKey == null)
			{
				_AcquisitionModelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAcquisitionModelKey");
			}
			return _AcquisitionModelKey;
		}
	}

	[Field("NSMetadataItemAlbumKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AlbumKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AlbumKey == null)
			{
				_AlbumKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAlbumKey");
			}
			return _AlbumKey;
		}
	}

	[Field("NSMetadataItemAltitudeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AltitudeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AltitudeKey == null)
			{
				_AltitudeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAltitudeKey");
			}
			return _AltitudeKey;
		}
	}

	[Field("NSMetadataItemApertureKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ApertureKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ApertureKey == null)
			{
				_ApertureKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemApertureKey");
			}
			return _ApertureKey;
		}
	}

	[Field("NSMetadataItemAppleLoopDescriptorsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AppleLoopDescriptorsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleLoopDescriptorsKey == null)
			{
				_AppleLoopDescriptorsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAppleLoopDescriptorsKey");
			}
			return _AppleLoopDescriptorsKey;
		}
	}

	[Field("NSMetadataItemAppleLoopsKeyFilterTypeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AppleLoopsKeyFilterTypeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleLoopsKeyFilterTypeKey == null)
			{
				_AppleLoopsKeyFilterTypeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsKeyFilterTypeKey");
			}
			return _AppleLoopsKeyFilterTypeKey;
		}
	}

	[Field("NSMetadataItemAppleLoopsLoopModeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AppleLoopsLoopModeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleLoopsLoopModeKey == null)
			{
				_AppleLoopsLoopModeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsLoopModeKey");
			}
			return _AppleLoopsLoopModeKey;
		}
	}

	[Field("NSMetadataItemAppleLoopsRootKeyKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AppleLoopsRootKeyKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleLoopsRootKeyKey == null)
			{
				_AppleLoopsRootKeyKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsRootKeyKey");
			}
			return _AppleLoopsRootKeyKey;
		}
	}

	[Field("NSMetadataItemApplicationCategoriesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ApplicationCategoriesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplicationCategoriesKey == null)
			{
				_ApplicationCategoriesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemApplicationCategoriesKey");
			}
			return _ApplicationCategoriesKey;
		}
	}

	[Field("NSMetadataItemAudiencesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudiencesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudiencesKey == null)
			{
				_AudiencesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudiencesKey");
			}
			return _AudiencesKey;
		}
	}

	[Field("NSMetadataItemAudioBitRateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudioBitRateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioBitRateKey == null)
			{
				_AudioBitRateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudioBitRateKey");
			}
			return _AudioBitRateKey;
		}
	}

	[Field("NSMetadataItemAudioChannelCountKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudioChannelCountKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioChannelCountKey == null)
			{
				_AudioChannelCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudioChannelCountKey");
			}
			return _AudioChannelCountKey;
		}
	}

	[Field("NSMetadataItemAudioEncodingApplicationKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudioEncodingApplicationKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioEncodingApplicationKey == null)
			{
				_AudioEncodingApplicationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudioEncodingApplicationKey");
			}
			return _AudioEncodingApplicationKey;
		}
	}

	[Field("NSMetadataItemAudioSampleRateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudioSampleRateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioSampleRateKey == null)
			{
				_AudioSampleRateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudioSampleRateKey");
			}
			return _AudioSampleRateKey;
		}
	}

	[Field("NSMetadataItemAudioTrackNumberKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AudioTrackNumberKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioTrackNumberKey == null)
			{
				_AudioTrackNumberKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAudioTrackNumberKey");
			}
			return _AudioTrackNumberKey;
		}
	}

	[Field("NSMetadataItemAuthorAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AuthorAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AuthorAddressesKey == null)
			{
				_AuthorAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAuthorAddressesKey");
			}
			return _AuthorAddressesKey;
		}
	}

	[Field("NSMetadataItemAuthorEmailAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AuthorEmailAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AuthorEmailAddressesKey == null)
			{
				_AuthorEmailAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAuthorEmailAddressesKey");
			}
			return _AuthorEmailAddressesKey;
		}
	}

	[Field("NSMetadataItemAuthorsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AuthorsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AuthorsKey == null)
			{
				_AuthorsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemAuthorsKey");
			}
			return _AuthorsKey;
		}
	}

	[Field("NSMetadataItemBitsPerSampleKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString BitsPerSampleKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_BitsPerSampleKey == null)
			{
				_BitsPerSampleKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemBitsPerSampleKey");
			}
			return _BitsPerSampleKey;
		}
	}

	[Field("NSMetadataItemCFBundleIdentifierKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CFBundleIdentifierKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CFBundleIdentifierKey == null)
			{
				_CFBundleIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCFBundleIdentifierKey");
			}
			return _CFBundleIdentifierKey;
		}
	}

	[Field("NSMetadataItemCameraOwnerKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CameraOwnerKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CameraOwnerKey == null)
			{
				_CameraOwnerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCameraOwnerKey");
			}
			return _CameraOwnerKey;
		}
	}

	[Field("NSMetadataItemCityKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CityKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CityKey == null)
			{
				_CityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCityKey");
			}
			return _CityKey;
		}
	}

	[Field("NSMetadataItemCodecsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CodecsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CodecsKey == null)
			{
				_CodecsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCodecsKey");
			}
			return _CodecsKey;
		}
	}

	[Field("NSMetadataItemColorSpaceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ColorSpaceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ColorSpaceKey == null)
			{
				_ColorSpaceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemColorSpaceKey");
			}
			return _ColorSpaceKey;
		}
	}

	[Field("NSMetadataItemCommentKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CommentKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CommentKey == null)
			{
				_CommentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCommentKey");
			}
			return _CommentKey;
		}
	}

	[Field("NSMetadataItemComposerKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ComposerKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ComposerKey == null)
			{
				_ComposerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemComposerKey");
			}
			return _ComposerKey;
		}
	}

	[Field("NSMetadataItemContactKeywordsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContactKeywordsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContactKeywordsKey == null)
			{
				_ContactKeywordsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContactKeywordsKey");
			}
			return _ContactKeywordsKey;
		}
	}

	[Field("NSMetadataItemContentCreationDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContentCreationDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentCreationDateKey == null)
			{
				_ContentCreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContentCreationDateKey");
			}
			return _ContentCreationDateKey;
		}
	}

	[Field("NSMetadataItemContentModificationDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContentModificationDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentModificationDateKey == null)
			{
				_ContentModificationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContentModificationDateKey");
			}
			return _ContentModificationDateKey;
		}
	}

	[Field("NSMetadataItemContentTypeKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContentTypeKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentTypeKey == null)
			{
				_ContentTypeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContentTypeKey");
			}
			return _ContentTypeKey;
		}
	}

	[Field("NSMetadataItemContentTypeTreeKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContentTypeTreeKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentTypeTreeKey == null)
			{
				_ContentTypeTreeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContentTypeTreeKey");
			}
			return _ContentTypeTreeKey;
		}
	}

	[Field("NSMetadataItemContributorsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContributorsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContributorsKey == null)
			{
				_ContributorsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemContributorsKey");
			}
			return _ContributorsKey;
		}
	}

	[Field("NSMetadataItemCopyrightKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CopyrightKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CopyrightKey == null)
			{
				_CopyrightKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCopyrightKey");
			}
			return _CopyrightKey;
		}
	}

	[Field("NSMetadataItemCountryKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CountryKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CountryKey == null)
			{
				_CountryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCountryKey");
			}
			return _CountryKey;
		}
	}

	[Field("NSMetadataItemCoverageKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CoverageKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CoverageKey == null)
			{
				_CoverageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCoverageKey");
			}
			return _CoverageKey;
		}
	}

	[Field("NSMetadataItemCreatorKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString CreatorKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_CreatorKey == null)
			{
				_CreatorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemCreatorKey");
			}
			return _CreatorKey;
		}
	}

	[Field("NSMetadataItemDateAddedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DateAddedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DateAddedKey == null)
			{
				_DateAddedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDateAddedKey");
			}
			return _DateAddedKey;
		}
	}

	[Field("NSMetadataItemDeliveryTypeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DeliveryTypeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DeliveryTypeKey == null)
			{
				_DeliveryTypeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDeliveryTypeKey");
			}
			return _DeliveryTypeKey;
		}
	}

	[Field("NSMetadataItemDescriptionKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DescriptionKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DescriptionKey == null)
			{
				_DescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDescriptionKey");
			}
			return _DescriptionKey;
		}
	}

	[Field("NSMetadataQueryDidFinishGatheringNotification", "Foundation")]
	[Advice("Use NSMetadataQuery.Notifications.ObserveDidFinishGathering helper method instead.")]
	public static NSString DidFinishGatheringNotification
	{
		get
		{
			if (_DidFinishGatheringNotification == null)
			{
				_DidFinishGatheringNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidFinishGatheringNotification");
			}
			return _DidFinishGatheringNotification;
		}
	}

	[Field("NSMetadataQueryDidStartGatheringNotification", "Foundation")]
	[Advice("Use NSMetadataQuery.Notifications.ObserveDidStartGathering helper method instead.")]
	public static NSString DidStartGatheringNotification
	{
		get
		{
			if (_DidStartGatheringNotification == null)
			{
				_DidStartGatheringNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidStartGatheringNotification");
			}
			return _DidStartGatheringNotification;
		}
	}

	[Field("NSMetadataQueryDidUpdateNotification", "Foundation")]
	[Advice("Use NSMetadataQuery.Notifications.ObserveDidUpdate helper method instead.")]
	public static NSString DidUpdateNotification
	{
		get
		{
			if (_DidUpdateNotification == null)
			{
				_DidUpdateNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidUpdateNotification");
			}
			return _DidUpdateNotification;
		}
	}

	[Field("NSMetadataItemDirectorKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DirectorKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DirectorKey == null)
			{
				_DirectorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDirectorKey");
			}
			return _DirectorKey;
		}
	}

	[Field("NSMetadataItemDownloadedDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DownloadedDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DownloadedDateKey == null)
			{
				_DownloadedDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDownloadedDateKey");
			}
			return _DownloadedDateKey;
		}
	}

	[Field("NSMetadataItemDueDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DueDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DueDateKey == null)
			{
				_DueDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDueDateKey");
			}
			return _DueDateKey;
		}
	}

	[Field("NSMetadataItemDurationSecondsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DurationSecondsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DurationSecondsKey == null)
			{
				_DurationSecondsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDurationSecondsKey");
			}
			return _DurationSecondsKey;
		}
	}

	[Field("NSMetadataItemEditorsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString EditorsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_EditorsKey == null)
			{
				_EditorsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemEditorsKey");
			}
			return _EditorsKey;
		}
	}

	[Field("NSMetadataItemEmailAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString EmailAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_EmailAddressesKey == null)
			{
				_EmailAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemEmailAddressesKey");
			}
			return _EmailAddressesKey;
		}
	}

	[Field("NSMetadataItemEncodingApplicationsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString EncodingApplicationsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_EncodingApplicationsKey == null)
			{
				_EncodingApplicationsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemEncodingApplicationsKey");
			}
			return _EncodingApplicationsKey;
		}
	}

	[Field("NSMetadataItemExecutableArchitecturesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExecutableArchitecturesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExecutableArchitecturesKey == null)
			{
				_ExecutableArchitecturesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExecutableArchitecturesKey");
			}
			return _ExecutableArchitecturesKey;
		}
	}

	[Field("NSMetadataItemExecutablePlatformKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExecutablePlatformKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExecutablePlatformKey == null)
			{
				_ExecutablePlatformKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExecutablePlatformKey");
			}
			return _ExecutablePlatformKey;
		}
	}

	[Field("NSMetadataItemEXIFGPSVersionKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifGpsVersionKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifGpsVersionKey == null)
			{
				_ExifGpsVersionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemEXIFGPSVersionKey");
			}
			return _ExifGpsVersionKey;
		}
	}

	[Field("NSMetadataItemEXIFVersionKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifVersionKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifVersionKey == null)
			{
				_ExifVersionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemEXIFVersionKey");
			}
			return _ExifVersionKey;
		}
	}

	[Field("NSMetadataItemExposureModeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExposureModeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExposureModeKey == null)
			{
				_ExposureModeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExposureModeKey");
			}
			return _ExposureModeKey;
		}
	}

	[Field("NSMetadataItemExposureProgramKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExposureProgramKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExposureProgramKey == null)
			{
				_ExposureProgramKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExposureProgramKey");
			}
			return _ExposureProgramKey;
		}
	}

	[Field("NSMetadataItemExposureTimeSecondsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExposureTimeSecondsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExposureTimeSecondsKey == null)
			{
				_ExposureTimeSecondsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExposureTimeSecondsKey");
			}
			return _ExposureTimeSecondsKey;
		}
	}

	[Field("NSMetadataItemExposureTimeStringKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExposureTimeStringKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExposureTimeStringKey == null)
			{
				_ExposureTimeStringKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemExposureTimeStringKey");
			}
			return _ExposureTimeStringKey;
		}
	}

	[Field("NSMetadataItemFNumberKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FNumberKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FNumberKey == null)
			{
				_FNumberKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFNumberKey");
			}
			return _FNumberKey;
		}
	}

	[Field("NSMetadataItemFinderCommentKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FinderCommentKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FinderCommentKey == null)
			{
				_FinderCommentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFinderCommentKey");
			}
			return _FinderCommentKey;
		}
	}

	[Field("NSMetadataItemFlashOnOffKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FlashOnOffKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FlashOnOffKey == null)
			{
				_FlashOnOffKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFlashOnOffKey");
			}
			return _FlashOnOffKey;
		}
	}

	[Field("NSMetadataItemFocalLength35mmKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FocalLength35mmKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FocalLength35mmKey == null)
			{
				_FocalLength35mmKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFocalLength35mmKey");
			}
			return _FocalLength35mmKey;
		}
	}

	[Field("NSMetadataItemFocalLengthKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FocalLengthKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FocalLengthKey == null)
			{
				_FocalLengthKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFocalLengthKey");
			}
			return _FocalLengthKey;
		}
	}

	[Field("NSMetadataItemFontsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString FontsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_FontsKey == null)
			{
				_FontsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFontsKey");
			}
			return _FontsKey;
		}
	}

	[Field("NSMetadataQueryGatheringProgressNotification", "Foundation")]
	[Advice("Use NSMetadataQuery.Notifications.ObserveGatheringProgress helper method instead.")]
	public static NSString GatheringProgressNotification
	{
		get
		{
			if (_GatheringProgressNotification == null)
			{
				_GatheringProgressNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryGatheringProgressNotification");
			}
			return _GatheringProgressNotification;
		}
	}

	[Field("NSMetadataItemGenreKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GenreKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GenreKey == null)
			{
				_GenreKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGenreKey");
			}
			return _GenreKey;
		}
	}

	[Field("NSMetadataItemGPSAreaInformationKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsAreaInformationKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsAreaInformationKey == null)
			{
				_GpsAreaInformationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSAreaInformationKey");
			}
			return _GpsAreaInformationKey;
		}
	}

	[Field("NSMetadataItemGPSDateStampKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDateStampKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDateStampKey == null)
			{
				_GpsDateStampKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDateStampKey");
			}
			return _GpsDateStampKey;
		}
	}

	[Field("NSMetadataItemGPSDestBearingKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDestBearingKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDestBearingKey == null)
			{
				_GpsDestBearingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDestBearingKey");
			}
			return _GpsDestBearingKey;
		}
	}

	[Field("NSMetadataItemGPSDestDistanceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDestDistanceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDestDistanceKey == null)
			{
				_GpsDestDistanceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDestDistanceKey");
			}
			return _GpsDestDistanceKey;
		}
	}

	[Field("NSMetadataItemGPSDestLatitudeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDestLatitudeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDestLatitudeKey == null)
			{
				_GpsDestLatitudeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDestLatitudeKey");
			}
			return _GpsDestLatitudeKey;
		}
	}

	[Field("NSMetadataItemGPSDestLongitudeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDestLongitudeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDestLongitudeKey == null)
			{
				_GpsDestLongitudeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDestLongitudeKey");
			}
			return _GpsDestLongitudeKey;
		}
	}

	[Field("NSMetadataItemGPSDifferentalKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDifferentalKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDifferentalKey == null)
			{
				_GpsDifferentalKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDifferentalKey");
			}
			return _GpsDifferentalKey;
		}
	}

	[Field("NSMetadataItemGPSDOPKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsDopKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsDopKey == null)
			{
				_GpsDopKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSDOPKey");
			}
			return _GpsDopKey;
		}
	}

	[Field("NSMetadataItemGPSMapDatumKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsMapDatumKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsMapDatumKey == null)
			{
				_GpsMapDatumKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSMapDatumKey");
			}
			return _GpsMapDatumKey;
		}
	}

	[Field("NSMetadataItemGPSMeasureModeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsMeasureModeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsMeasureModeKey == null)
			{
				_GpsMeasureModeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSMeasureModeKey");
			}
			return _GpsMeasureModeKey;
		}
	}

	[Field("NSMetadataItemGPSProcessingMethodKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsProcessingMethodKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsProcessingMethodKey == null)
			{
				_GpsProcessingMethodKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSProcessingMethodKey");
			}
			return _GpsProcessingMethodKey;
		}
	}

	[Field("NSMetadataItemGPSStatusKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsStatusKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsStatusKey == null)
			{
				_GpsStatusKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSStatusKey");
			}
			return _GpsStatusKey;
		}
	}

	[Field("NSMetadataItemGPSTrackKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString GpsTrackKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_GpsTrackKey == null)
			{
				_GpsTrackKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemGPSTrackKey");
			}
			return _GpsTrackKey;
		}
	}

	[Field("NSMetadataItemHasAlphaChannelKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString HasAlphaChannelKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_HasAlphaChannelKey == null)
			{
				_HasAlphaChannelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemHasAlphaChannelKey");
			}
			return _HasAlphaChannelKey;
		}
	}

	[Field("NSMetadataItemHeadlineKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString HeadlineKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_HeadlineKey == null)
			{
				_HeadlineKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemHeadlineKey");
			}
			return _HeadlineKey;
		}
	}

	[Field("NSMetadataItemIdentifierKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IdentifierKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IdentifierKey == null)
			{
				_IdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIdentifierKey");
			}
			return _IdentifierKey;
		}
	}

	[Field("NSMetadataItemImageDirectionKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ImageDirectionKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ImageDirectionKey == null)
			{
				_ImageDirectionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemImageDirectionKey");
			}
			return _ImageDirectionKey;
		}
	}

	[Field("NSMetadataItemInformationKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString InformationKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_InformationKey == null)
			{
				_InformationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemInformationKey");
			}
			return _InformationKey;
		}
	}

	[Field("NSMetadataItemInstantMessageAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString InstantMessageAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_InstantMessageAddressesKey == null)
			{
				_InstantMessageAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemInstantMessageAddressesKey");
			}
			return _InstantMessageAddressesKey;
		}
	}

	[Field("NSMetadataItemInstructionsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString InstructionsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_InstructionsKey == null)
			{
				_InstructionsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemInstructionsKey");
			}
			return _InstructionsKey;
		}
	}

	[Field("NSMetadataItemIsApplicationManagedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsApplicationManagedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsApplicationManagedKey == null)
			{
				_IsApplicationManagedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIsApplicationManagedKey");
			}
			return _IsApplicationManagedKey;
		}
	}

	[Field("NSMetadataItemIsGeneralMIDISequenceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsGeneralMidiSequenceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsGeneralMidiSequenceKey == null)
			{
				_IsGeneralMidiSequenceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIsGeneralMIDISequenceKey");
			}
			return _IsGeneralMidiSequenceKey;
		}
	}

	[Field("NSMetadataItemIsLikelyJunkKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsLikelyJunkKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsLikelyJunkKey == null)
			{
				_IsLikelyJunkKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIsLikelyJunkKey");
			}
			return _IsLikelyJunkKey;
		}
	}

	[Field("NSMetadataItemISOSpeedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString IsoSpeedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_IsoSpeedKey == null)
			{
				_IsoSpeedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemISOSpeedKey");
			}
			return _IsoSpeedKey;
		}
	}

	[Field("NSMetadataItemDisplayNameKey", "Foundation")]
	public static NSString ItemDisplayNameKey
	{
		get
		{
			if (_ItemDisplayNameKey == null)
			{
				_ItemDisplayNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDisplayNameKey");
			}
			return _ItemDisplayNameKey;
		}
	}

	[Field("NSMetadataItemFSContentChangeDateKey", "Foundation")]
	public static NSString ItemFSContentChangeDateKey
	{
		get
		{
			if (_ItemFSContentChangeDateKey == null)
			{
				_ItemFSContentChangeDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSContentChangeDateKey");
			}
			return _ItemFSContentChangeDateKey;
		}
	}

	[Field("NSMetadataItemFSCreationDateKey", "Foundation")]
	public static NSString ItemFSCreationDateKey
	{
		get
		{
			if (_ItemFSCreationDateKey == null)
			{
				_ItemFSCreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSCreationDateKey");
			}
			return _ItemFSCreationDateKey;
		}
	}

	[Field("NSMetadataItemFSNameKey", "Foundation")]
	public static NSString ItemFSNameKey
	{
		get
		{
			if (_ItemFSNameKey == null)
			{
				_ItemFSNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSNameKey");
			}
			return _ItemFSNameKey;
		}
	}

	[Field("NSMetadataItemFSSizeKey", "Foundation")]
	public static NSString ItemFSSizeKey
	{
		get
		{
			if (_ItemFSSizeKey == null)
			{
				_ItemFSSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSSizeKey");
			}
			return _ItemFSSizeKey;
		}
	}

	[Field("NSMetadataItemIsUbiquitousKey", "Foundation")]
	public static NSString ItemIsUbiquitousKey
	{
		get
		{
			if (_ItemIsUbiquitousKey == null)
			{
				_ItemIsUbiquitousKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIsUbiquitousKey");
			}
			return _ItemIsUbiquitousKey;
		}
	}

	[Field("NSMetadataItemPathKey", "Foundation")]
	public static NSString ItemPathKey
	{
		get
		{
			if (_ItemPathKey == null)
			{
				_ItemPathKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPathKey");
			}
			return _ItemPathKey;
		}
	}

	[Field("NSMetadataItemURLKey", "Foundation")]
	public static NSString ItemURLKey
	{
		get
		{
			if (_ItemURLKey == null)
			{
				_ItemURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemURLKey");
			}
			return _ItemURLKey;
		}
	}

	[Field("NSMetadataItemKeySignatureKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString KeySignatureKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_KeySignatureKey == null)
			{
				_KeySignatureKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemKeySignatureKey");
			}
			return _KeySignatureKey;
		}
	}

	[Field("NSMetadataItemKeywordsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString KeywordsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_KeywordsKey == null)
			{
				_KeywordsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemKeywordsKey");
			}
			return _KeywordsKey;
		}
	}

	[Field("NSMetadataItemKindKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString KindKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_KindKey == null)
			{
				_KindKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemKindKey");
			}
			return _KindKey;
		}
	}

	[Field("NSMetadataItemLanguagesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LanguagesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LanguagesKey == null)
			{
				_LanguagesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLanguagesKey");
			}
			return _LanguagesKey;
		}
	}

	[Field("NSMetadataItemLastUsedDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LastUsedDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LastUsedDateKey == null)
			{
				_LastUsedDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLastUsedDateKey");
			}
			return _LastUsedDateKey;
		}
	}

	[Field("NSMetadataItemLatitudeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LatitudeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LatitudeKey == null)
			{
				_LatitudeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLatitudeKey");
			}
			return _LatitudeKey;
		}
	}

	[Field("NSMetadataItemLayerNamesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LayerNamesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LayerNamesKey == null)
			{
				_LayerNamesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLayerNamesKey");
			}
			return _LayerNamesKey;
		}
	}

	[Field("NSMetadataItemLensModelKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LensModelKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LensModelKey == null)
			{
				_LensModelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLensModelKey");
			}
			return _LensModelKey;
		}
	}

	[Field("NSMetadataQueryLocalComputerScope", "Foundation")]
	public static NSString LocalComputerScope
	{
		get
		{
			if (_LocalComputerScope == null)
			{
				_LocalComputerScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryLocalComputerScope");
			}
			return _LocalComputerScope;
		}
	}

	[Field("NSMetadataQueryLocalDocumentsScope", "Foundation")]
	public static NSString LocalDocumentsScope
	{
		get
		{
			if (_LocalDocumentsScope == null)
			{
				_LocalDocumentsScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryLocalDocumentsScope");
			}
			return _LocalDocumentsScope;
		}
	}

	[Field("NSMetadataItemLongitudeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LongitudeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LongitudeKey == null)
			{
				_LongitudeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLongitudeKey");
			}
			return _LongitudeKey;
		}
	}

	[Field("NSMetadataItemLyricistKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LyricistKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LyricistKey == null)
			{
				_LyricistKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemLyricistKey");
			}
			return _LyricistKey;
		}
	}

	[Field("NSMetadataItemMaxApertureKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MaxApertureKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MaxApertureKey == null)
			{
				_MaxApertureKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMaxApertureKey");
			}
			return _MaxApertureKey;
		}
	}

	[Field("NSMetadataItemMediaTypesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MediaTypesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MediaTypesKey == null)
			{
				_MediaTypesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMediaTypesKey");
			}
			return _MediaTypesKey;
		}
	}

	[Field("NSMetadataItemMeteringModeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MeteringModeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MeteringModeKey == null)
			{
				_MeteringModeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMeteringModeKey");
			}
			return _MeteringModeKey;
		}
	}

	[Field("NSMetadataItemMusicalGenreKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MusicalGenreKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MusicalGenreKey == null)
			{
				_MusicalGenreKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMusicalGenreKey");
			}
			return _MusicalGenreKey;
		}
	}

	[Field("NSMetadataItemMusicalInstrumentCategoryKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MusicalInstrumentCategoryKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MusicalInstrumentCategoryKey == null)
			{
				_MusicalInstrumentCategoryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMusicalInstrumentCategoryKey");
			}
			return _MusicalInstrumentCategoryKey;
		}
	}

	[Field("NSMetadataItemMusicalInstrumentNameKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MusicalInstrumentNameKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MusicalInstrumentNameKey == null)
			{
				_MusicalInstrumentNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemMusicalInstrumentNameKey");
			}
			return _MusicalInstrumentNameKey;
		}
	}

	[Field("NSMetadataItemNamedLocationKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString NamedLocationKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_NamedLocationKey == null)
			{
				_NamedLocationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemNamedLocationKey");
			}
			return _NamedLocationKey;
		}
	}

	[Field("NSMetadataQueryNetworkScope", "Foundation")]
	public static NSString NetworkScope
	{
		get
		{
			if (_NetworkScope == null)
			{
				_NetworkScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryNetworkScope");
			}
			return _NetworkScope;
		}
	}

	[Field("NSMetadataItemNumberOfPagesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString NumberOfPagesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_NumberOfPagesKey == null)
			{
				_NumberOfPagesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemNumberOfPagesKey");
			}
			return _NumberOfPagesKey;
		}
	}

	[Field("NSMetadataItemOrganizationsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OrganizationsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OrganizationsKey == null)
			{
				_OrganizationsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemOrganizationsKey");
			}
			return _OrganizationsKey;
		}
	}

	[Field("NSMetadataItemOrientationKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OrientationKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OrientationKey == null)
			{
				_OrientationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemOrientationKey");
			}
			return _OrientationKey;
		}
	}

	[Field("NSMetadataItemOriginalFormatKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OriginalFormatKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OriginalFormatKey == null)
			{
				_OriginalFormatKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemOriginalFormatKey");
			}
			return _OriginalFormatKey;
		}
	}

	[Field("NSMetadataItemOriginalSourceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OriginalSourceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OriginalSourceKey == null)
			{
				_OriginalSourceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemOriginalSourceKey");
			}
			return _OriginalSourceKey;
		}
	}

	[Field("NSMetadataItemPageHeightKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PageHeightKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PageHeightKey == null)
			{
				_PageHeightKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPageHeightKey");
			}
			return _PageHeightKey;
		}
	}

	[Field("NSMetadataItemPageWidthKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PageWidthKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PageWidthKey == null)
			{
				_PageWidthKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPageWidthKey");
			}
			return _PageWidthKey;
		}
	}

	[Field("NSMetadataItemParticipantsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ParticipantsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ParticipantsKey == null)
			{
				_ParticipantsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemParticipantsKey");
			}
			return _ParticipantsKey;
		}
	}

	[Field("NSMetadataItemPerformersKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PerformersKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PerformersKey == null)
			{
				_PerformersKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPerformersKey");
			}
			return _PerformersKey;
		}
	}

	[Field("NSMetadataItemPhoneNumbersKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PhoneNumbersKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PhoneNumbersKey == null)
			{
				_PhoneNumbersKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPhoneNumbersKey");
			}
			return _PhoneNumbersKey;
		}
	}

	[Field("NSMetadataItemPixelCountKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PixelCountKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PixelCountKey == null)
			{
				_PixelCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPixelCountKey");
			}
			return _PixelCountKey;
		}
	}

	[Field("NSMetadataItemPixelHeightKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PixelHeightKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PixelHeightKey == null)
			{
				_PixelHeightKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPixelHeightKey");
			}
			return _PixelHeightKey;
		}
	}

	[Field("NSMetadataItemPixelWidthKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PixelWidthKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PixelWidthKey == null)
			{
				_PixelWidthKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPixelWidthKey");
			}
			return _PixelWidthKey;
		}
	}

	[Field("NSMetadataItemProducerKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProducerKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProducerKey == null)
			{
				_ProducerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemProducerKey");
			}
			return _ProducerKey;
		}
	}

	[Field("NSMetadataItemProfileNameKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileNameKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileNameKey == null)
			{
				_ProfileNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemProfileNameKey");
			}
			return _ProfileNameKey;
		}
	}

	[Field("NSMetadataItemProjectsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProjectsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProjectsKey == null)
			{
				_ProjectsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemProjectsKey");
			}
			return _ProjectsKey;
		}
	}

	[Field("NSMetadataItemPublishersKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PublishersKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PublishersKey == null)
			{
				_PublishersKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPublishersKey");
			}
			return _PublishersKey;
		}
	}

	[Field("NSMetadataQueryUpdateAddedItemsKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString QueryUpdateAddedItemsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QueryUpdateAddedItemsKey == null)
			{
				_QueryUpdateAddedItemsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUpdateAddedItemsKey");
			}
			return _QueryUpdateAddedItemsKey;
		}
	}

	[Field("NSMetadataQueryUpdateChangedItemsKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString QueryUpdateChangedItemsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QueryUpdateChangedItemsKey == null)
			{
				_QueryUpdateChangedItemsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUpdateChangedItemsKey");
			}
			return _QueryUpdateChangedItemsKey;
		}
	}

	[Field("NSMetadataQueryUpdateRemovedItemsKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString QueryUpdateRemovedItemsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QueryUpdateRemovedItemsKey == null)
			{
				_QueryUpdateRemovedItemsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUpdateRemovedItemsKey");
			}
			return _QueryUpdateRemovedItemsKey;
		}
	}

	[Field("NSMetadataItemRecipientAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RecipientAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RecipientAddressesKey == null)
			{
				_RecipientAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRecipientAddressesKey");
			}
			return _RecipientAddressesKey;
		}
	}

	[Field("NSMetadataItemRecipientEmailAddressesKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RecipientEmailAddressesKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RecipientEmailAddressesKey == null)
			{
				_RecipientEmailAddressesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRecipientEmailAddressesKey");
			}
			return _RecipientEmailAddressesKey;
		}
	}

	[Field("NSMetadataItemRecipientsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RecipientsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RecipientsKey == null)
			{
				_RecipientsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRecipientsKey");
			}
			return _RecipientsKey;
		}
	}

	[Field("NSMetadataItemRecordingDateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RecordingDateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RecordingDateKey == null)
			{
				_RecordingDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRecordingDateKey");
			}
			return _RecordingDateKey;
		}
	}

	[Field("NSMetadataItemRecordingYearKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RecordingYearKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RecordingYearKey == null)
			{
				_RecordingYearKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRecordingYearKey");
			}
			return _RecordingYearKey;
		}
	}

	[Field("NSMetadataItemRedEyeOnOffKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RedEyeOnOffKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RedEyeOnOffKey == null)
			{
				_RedEyeOnOffKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRedEyeOnOffKey");
			}
			return _RedEyeOnOffKey;
		}
	}

	[Field("NSMetadataItemResolutionHeightDPIKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ResolutionHeightDpiKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ResolutionHeightDpiKey == null)
			{
				_ResolutionHeightDpiKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemResolutionHeightDPIKey");
			}
			return _ResolutionHeightDpiKey;
		}
	}

	[Field("NSMetadataItemResolutionWidthDPIKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ResolutionWidthDpiKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ResolutionWidthDpiKey == null)
			{
				_ResolutionWidthDpiKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemResolutionWidthDPIKey");
			}
			return _ResolutionWidthDpiKey;
		}
	}

	[Field("NSMetadataQueryResultContentRelevanceAttribute", "Foundation")]
	public static NSString ResultContentRelevanceAttribute
	{
		get
		{
			if (_ResultContentRelevanceAttribute == null)
			{
				_ResultContentRelevanceAttribute = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryResultContentRelevanceAttribute");
			}
			return _ResultContentRelevanceAttribute;
		}
	}

	[Field("NSMetadataItemRightsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RightsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RightsKey == null)
			{
				_RightsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemRightsKey");
			}
			return _RightsKey;
		}
	}

	[Field("NSMetadataItemSecurityMethodKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SecurityMethodKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SecurityMethodKey == null)
			{
				_SecurityMethodKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemSecurityMethodKey");
			}
			return _SecurityMethodKey;
		}
	}

	[Field("NSMetadataItemSpeedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SpeedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SpeedKey == null)
			{
				_SpeedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemSpeedKey");
			}
			return _SpeedKey;
		}
	}

	[Field("NSMetadataItemStarRatingKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString StarRatingKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_StarRatingKey == null)
			{
				_StarRatingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemStarRatingKey");
			}
			return _StarRatingKey;
		}
	}

	[Field("NSMetadataItemStateOrProvinceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString StateOrProvinceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_StateOrProvinceKey == null)
			{
				_StateOrProvinceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemStateOrProvinceKey");
			}
			return _StateOrProvinceKey;
		}
	}

	[Field("NSMetadataItemStreamableKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString StreamableKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_StreamableKey == null)
			{
				_StreamableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemStreamableKey");
			}
			return _StreamableKey;
		}
	}

	[Field("NSMetadataItemSubjectKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SubjectKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SubjectKey == null)
			{
				_SubjectKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemSubjectKey");
			}
			return _SubjectKey;
		}
	}

	[Field("NSMetadataItemTempoKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TempoKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TempoKey == null)
			{
				_TempoKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTempoKey");
			}
			return _TempoKey;
		}
	}

	[Field("NSMetadataItemTextContentKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TextContentKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TextContentKey == null)
			{
				_TextContentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTextContentKey");
			}
			return _TextContentKey;
		}
	}

	[Field("NSMetadataItemThemeKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ThemeKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ThemeKey == null)
			{
				_ThemeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemThemeKey");
			}
			return _ThemeKey;
		}
	}

	[Field("NSMetadataItemTimeSignatureKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TimeSignatureKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TimeSignatureKey == null)
			{
				_TimeSignatureKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTimeSignatureKey");
			}
			return _TimeSignatureKey;
		}
	}

	[Field("NSMetadataItemTimestampKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TimestampKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TimestampKey == null)
			{
				_TimestampKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTimestampKey");
			}
			return _TimestampKey;
		}
	}

	[Field("NSMetadataItemTitleKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TitleKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TitleKey == null)
			{
				_TitleKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTitleKey");
			}
			return _TitleKey;
		}
	}

	[Field("NSMetadataItemTotalBitRateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TotalBitRateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TotalBitRateKey == null)
			{
				_TotalBitRateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemTotalBitRateKey");
			}
			return _TotalBitRateKey;
		}
	}

	[Field("NSMetadataQueryUbiquitousDataScope", "Foundation")]
	public static NSString UbiquitousDataScope
	{
		get
		{
			if (_UbiquitousDataScope == null)
			{
				_UbiquitousDataScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDataScope");
			}
			return _UbiquitousDataScope;
		}
	}

	[Field("NSMetadataQueryUbiquitousDocumentsScope", "Foundation")]
	public static NSString UbiquitousDocumentsScope
	{
		get
		{
			if (_UbiquitousDocumentsScope == null)
			{
				_UbiquitousDocumentsScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDocumentsScope");
			}
			return _UbiquitousDocumentsScope;
		}
	}

	[Field("NSMetadataUbiquitousItemContainerDisplayNameKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemContainerDisplayNameKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemContainerDisplayNameKey == null)
			{
				_UbiquitousItemContainerDisplayNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemContainerDisplayNameKey");
			}
			return _UbiquitousItemContainerDisplayNameKey;
		}
	}

	[Field("NSMetadataUbiquitousItemDownloadRequestedKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadRequestedKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadRequestedKey == null)
			{
				_UbiquitousItemDownloadRequestedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadRequestedKey");
			}
			return _UbiquitousItemDownloadRequestedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemDownloadingErrorKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingErrorKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingErrorKey == null)
			{
				_UbiquitousItemDownloadingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingErrorKey");
			}
			return _UbiquitousItemDownloadingErrorKey;
		}
	}

	[Field("NSMetadataUbiquitousItemDownloadingStatusKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingStatusKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingStatusKey == null)
			{
				_UbiquitousItemDownloadingStatusKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusKey");
			}
			return _UbiquitousItemDownloadingStatusKey;
		}
	}

	[Field("NSMetadataUbiquitousItemHasUnresolvedConflictsKey", "Foundation")]
	public static NSString UbiquitousItemHasUnresolvedConflictsKey
	{
		get
		{
			if (_UbiquitousItemHasUnresolvedConflictsKey == null)
			{
				_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemHasUnresolvedConflictsKey");
			}
			return _UbiquitousItemHasUnresolvedConflictsKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsDownloadedKey", "Foundation")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
	public static NSString UbiquitousItemIsDownloadedKey
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		get
		{
			if (_UbiquitousItemIsDownloadedKey == null)
			{
				_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadedKey");
			}
			return _UbiquitousItemIsDownloadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsDownloadingKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadingKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadingKey == null)
			{
				_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadingKey");
			}
			return _UbiquitousItemIsDownloadingKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsExternalDocumentKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemIsExternalDocumentKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemIsExternalDocumentKey == null)
			{
				_UbiquitousItemIsExternalDocumentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsExternalDocumentKey");
			}
			return _UbiquitousItemIsExternalDocumentKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsSharedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemIsSharedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemIsSharedKey == null)
			{
				_UbiquitousItemIsSharedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsSharedKey");
			}
			return _UbiquitousItemIsSharedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsUploadedKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadedKey
	{
		get
		{
			if (_UbiquitousItemIsUploadedKey == null)
			{
				_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadedKey");
			}
			return _UbiquitousItemIsUploadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsUploadingKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadingKey
	{
		get
		{
			if (_UbiquitousItemIsUploadingKey == null)
			{
				_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadingKey");
			}
			return _UbiquitousItemIsUploadingKey;
		}
	}

	[Field("NSMetadataUbiquitousItemPercentDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentDownloadedKey
	{
		get
		{
			if (_UbiquitousItemPercentDownloadedKey == null)
			{
				_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentDownloadedKey");
			}
			return _UbiquitousItemPercentDownloadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemPercentUploadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentUploadedKey
	{
		get
		{
			if (_UbiquitousItemPercentUploadedKey == null)
			{
				_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentUploadedKey");
			}
			return _UbiquitousItemPercentUploadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemURLInLocalContainerKey", "Foundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemURLInLocalContainerKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemURLInLocalContainerKey == null)
			{
				_UbiquitousItemURLInLocalContainerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemURLInLocalContainerKey");
			}
			return _UbiquitousItemURLInLocalContainerKey;
		}
	}

	[Field("NSMetadataUbiquitousItemUploadingErrorKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemUploadingErrorKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemUploadingErrorKey == null)
			{
				_UbiquitousItemUploadingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemUploadingErrorKey");
			}
			return _UbiquitousItemUploadingErrorKey;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemCurrentUserPermissionsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemCurrentUserPermissionsKey == null)
			{
				_UbiquitousSharedItemCurrentUserPermissionsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey");
			}
			return _UbiquitousSharedItemCurrentUserPermissionsKey;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemCurrentUserRoleKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemCurrentUserRoleKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemCurrentUserRoleKey == null)
			{
				_UbiquitousSharedItemCurrentUserRoleKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemCurrentUserRoleKey");
			}
			return _UbiquitousSharedItemCurrentUserRoleKey;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemMostRecentEditorNameComponentsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemMostRecentEditorNameComponentsKey == null)
			{
				_UbiquitousSharedItemMostRecentEditorNameComponentsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey");
			}
			return _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemOwnerNameComponentsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemOwnerNameComponentsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemOwnerNameComponentsKey == null)
			{
				_UbiquitousSharedItemOwnerNameComponentsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemOwnerNameComponentsKey");
			}
			return _UbiquitousSharedItemOwnerNameComponentsKey;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemPermissionsReadOnly", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemPermissionsReadOnly
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemPermissionsReadOnly == null)
			{
				_UbiquitousSharedItemPermissionsReadOnly = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemPermissionsReadOnly");
			}
			return _UbiquitousSharedItemPermissionsReadOnly;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemPermissionsReadWrite", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemPermissionsReadWrite
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemPermissionsReadWrite == null)
			{
				_UbiquitousSharedItemPermissionsReadWrite = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemPermissionsReadWrite");
			}
			return _UbiquitousSharedItemPermissionsReadWrite;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemRoleOwner", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemRoleOwner
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemRoleOwner == null)
			{
				_UbiquitousSharedItemRoleOwner = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemRoleOwner");
			}
			return _UbiquitousSharedItemRoleOwner;
		}
	}

	[Field("NSMetadataUbiquitousSharedItemRoleParticipant", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemRoleParticipant
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemRoleParticipant == null)
			{
				_UbiquitousSharedItemRoleParticipant = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemRoleParticipant");
			}
			return _UbiquitousSharedItemRoleParticipant;
		}
	}

	[Field("NSMetadataQueryUserHomeScope", "Foundation")]
	public static NSString UserHomeScope
	{
		get
		{
			if (_UserHomeScope == null)
			{
				_UserHomeScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUserHomeScope");
			}
			return _UserHomeScope;
		}
	}

	[Field("NSMetadataItemVersionKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString VersionKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_VersionKey == null)
			{
				_VersionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemVersionKey");
			}
			return _VersionKey;
		}
	}

	[Field("NSMetadataItemVideoBitRateKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString VideoBitRateKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_VideoBitRateKey == null)
			{
				_VideoBitRateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemVideoBitRateKey");
			}
			return _VideoBitRateKey;
		}
	}

	[Field("NSMetadataItemWhereFromsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString WhereFromsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_WhereFromsKey == null)
			{
				_WhereFromsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemWhereFromsKey");
			}
			return _WhereFromsKey;
		}
	}

	[Field("NSMetadataItemWhiteBalanceKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString WhiteBalanceKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_WhiteBalanceKey == null)
			{
				_WhiteBalanceKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemWhiteBalanceKey");
			}
			return _WhiteBalanceKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSMetadataQueryDelegate);

	public NSMetadataQueryObject? ReplacementObjectForResultObject
	{
		get
		{
			return EnsureNSMetadataQueryDelegate().replacementObjectForResultObject;
		}
		set
		{
			EnsureNSMetadataQueryDelegate().replacementObjectForResultObject = value;
		}
	}

	public NSMetadataQueryValue? ReplacementValueForAttributevalue
	{
		get
		{
			return EnsureNSMetadataQueryDelegate().replacementValueForAttributevalue;
		}
		set
		{
			EnsureNSMetadataQueryDelegate().replacementValueForAttributevalue = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQuery()
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
	protected NSMetadataQuery(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMetadataQuery(IntPtr handle)
		: base(handle)
	{
	}

	[Export("disableUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableUpdates()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableUpdatesHandle);
		}
	}

	[Export("enableUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableUpdates()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableUpdatesHandle);
		}
	}

	[Export("enumerateResultsUsingBlock:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateResultsUsingBlock([BlockProxy(typeof(Trampolines.NIDNSMetadataQueryEnumerationCallback))] NSMetadataQueryEnumerationCallback callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSMetadataQueryEnumerationCallback.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateResultsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateResultsUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateResultsWithOptions:usingBlock:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateResultsWithOptions(NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDNSMetadataQueryEnumerationCallback))] NSMetadataQueryEnumerationCallback block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSMetadataQueryEnumerationCallback.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selEnumerateResultsWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selEnumerateResultsWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("indexOfResult:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfResult(NSObject result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfResult_Handle, result.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfResult_Handle, result.Handle);
	}

	[Export("resultAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ResultAtIndex(nint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selResultAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selResultAtIndex_Handle, idx));
	}

	[Export("startQuery")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartQuery()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartQueryHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartQueryHandle);
	}

	[Export("stopQuery")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopQuery()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopQueryHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopQueryHandle);
		}
	}

	[Export("valueOfAttribute:forResultAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueOfAttribute(string attribyteName, nint atIndex)
	{
		if (attribyteName == null)
		{
			throw new ArgumentNullException("attribyteName");
		}
		IntPtr arg = NSString.CreateNative(attribyteName);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selValueOfAttribute_ForResultAtIndex_Handle, arg, atIndex)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, selValueOfAttribute_ForResultAtIndex_Handle, arg, atIndex)));
		NSString.ReleaseNative(arg);
		return result;
	}

	internal virtual _NSMetadataQueryDelegate CreateInternalEventDelegateType()
	{
		return new _NSMetadataQueryDelegate();
	}

	internal _NSMetadataQueryDelegate EnsureNSMetadataQueryDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSMetadataQueryDelegate nSMetadataQueryDelegate = Delegate as _NSMetadataQueryDelegate;
		if (nSMetadataQueryDelegate == null)
		{
			nSMetadataQueryDelegate = (_NSMetadataQueryDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSMetadataQueryDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
