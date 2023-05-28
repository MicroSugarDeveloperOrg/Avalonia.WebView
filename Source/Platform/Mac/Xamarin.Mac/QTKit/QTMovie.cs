using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMovie", true)]
public class QTMovie : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	public static class Notifications
	{
		public static NSObject ObserveApertureModeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApertureModeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApertureModeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApertureModeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveChapterDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChapterDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveChapterListDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterListDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChapterListDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterListDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveCloseWindowRequest(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CloseWindowRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCloseWindowRequest(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CloseWindowRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEnd(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEnd(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveEditabilityDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EditabilityDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveEditabilityDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EditabilityDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveEdited(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EditedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveEdited(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EditedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveEnterFullScreenRequest(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EnterFullScreenRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveEnterFullScreenRequest(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EnterFullScreenRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveExitFullScreenRequest(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ExitFullScreenRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveExitFullScreenRequest(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ExitFullScreenRequestNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveLoadStateDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LoadStateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveLoadStateDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LoadStateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveLoopModeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LoopModeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveLoopModeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LoopModeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMessageStringPosted(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MessageStringPostedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMessageStringPosted(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MessageStringPostedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRateDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRateDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSizeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SizeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSizeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SizeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveStatusStringPosted(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StatusStringPostedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveStatusStringPosted(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StatusStringPostedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTimeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTimeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveVolumeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(VolumeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveVolumeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(VolumeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddImage_ForDuration_WithAttributes_ = "addImage:forDuration:withAttributes:";

	private static readonly IntPtr selAddImage_ForDuration_WithAttributes_Handle = Selector.GetHandle("addImage:forDuration:withAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendSelectionFromMovie_ = "appendSelectionFromMovie:";

	private static readonly IntPtr selAppendSelectionFromMovie_Handle = Selector.GetHandle("appendSelectionFromMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachToCurrentThread = "attachToCurrentThread";

	private static readonly IntPtr selAttachToCurrentThreadHandle = Selector.GetHandle("attachToCurrentThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoplay = "autoplay";

	private static readonly IntPtr selAutoplayHandle = Selector.GetHandle("autoplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithFile_ = "canInitWithFile:";

	private static readonly IntPtr selCanInitWithFile_Handle = Selector.GetHandle("canInitWithFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithPasteboard_ = "canInitWithPasteboard:";

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithURL_ = "canInitWithURL:";

	private static readonly IntPtr selCanInitWithURL_Handle = Selector.GetHandle("canInitWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanUpdateMovieFile = "canUpdateMovieFile";

	private static readonly IntPtr selCanUpdateMovieFileHandle = Selector.GetHandle("canUpdateMovieFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChapterCount = "chapterCount";

	private static readonly IntPtr selChapterCountHandle = Selector.GetHandle("chapterCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChapterIndexForTime_ = "chapterIndexForTime:";

	private static readonly IntPtr selChapterIndexForTime_Handle = Selector.GetHandle("chapterIndexForTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChapters = "chapters";

	private static readonly IntPtr selChaptersHandle = Selector.GetHandle("chapters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentFrameImage = "currentFrameImage";

	private static readonly IntPtr selCurrentFrameImageHandle = Selector.GetHandle("currentFrameImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSegment_ = "deleteSegment:";

	private static readonly IntPtr selDeleteSegment_Handle = Selector.GetHandle("deleteSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachFromCurrentThread = "detachFromCurrentThread";

	private static readonly IntPtr selDetachFromCurrentThreadHandle = Selector.GetHandle("detachFromCurrentThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnterQTKitOnThread = "enterQTKitOnThread";

	private static readonly IntPtr selEnterQTKitOnThreadHandle = Selector.GetHandle("enterQTKitOnThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnterQTKitOnThreadDisablingThreadSafetyProtection = "enterQTKitOnThreadDisablingThreadSafetyProtection";

	private static readonly IntPtr selEnterQTKitOnThreadDisablingThreadSafetyProtectionHandle = Selector.GetHandle("enterQTKitOnThreadDisablingThreadSafetyProtection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExitQTKitOnThread = "exitQTKitOnThread";

	private static readonly IntPtr selExitQTKitOnThreadHandle = Selector.GetHandle("exitQTKitOnThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameImageAtTime_ = "frameImageAtTime:";

	private static readonly IntPtr selFrameImageAtTime_Handle = Selector.GetHandle("frameImageAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameImageAtTime_WithAttributes_Error_ = "frameImageAtTime:withAttributes:error:";

	private static readonly IntPtr selFrameImageAtTime_WithAttributes_Error_Handle = Selector.GetHandle("frameImageAtTime:withAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateApertureModeDimensions = "generateApertureModeDimensions";

	private static readonly IntPtr selGenerateApertureModeDimensionsHandle = Selector.GetHandle("generateApertureModeDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoBeginning = "gotoBeginning";

	private static readonly IntPtr selGotoBeginningHandle = Selector.GetHandle("gotoBeginning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoEnd = "gotoEnd";

	private static readonly IntPtr selGotoEndHandle = Selector.GetHandle("gotoEnd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoNextSelectionPoint = "gotoNextSelectionPoint";

	private static readonly IntPtr selGotoNextSelectionPointHandle = Selector.GetHandle("gotoNextSelectionPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoPosterTime = "gotoPosterTime";

	private static readonly IntPtr selGotoPosterTimeHandle = Selector.GetHandle("gotoPosterTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoPreviousSelectionPoint = "gotoPreviousSelectionPoint";

	private static readonly IntPtr selGotoPreviousSelectionPointHandle = Selector.GetHandle("gotoPreviousSelectionPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasChapters = "hasChapters";

	private static readonly IntPtr selHasChaptersHandle = Selector.GetHandle("hasChapters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitToWritableData_Error_ = "initToWritableData:error:";

	private static readonly IntPtr selInitToWritableData_Error_Handle = Selector.GetHandle("initToWritableData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttributes_Error_ = "initWithAttributes:error:";

	private static readonly IntPtr selInitWithAttributes_Error_Handle = Selector.GetHandle("initWithAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Error_ = "initWithData:error:";

	private static readonly IntPtr selInitWithData_Error_Handle = Selector.GetHandle("initWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDataReference_Error_ = "initWithDataReference:error:";

	private static readonly IntPtr selInitWithDataReference_Error_Handle = Selector.GetHandle("initWithDataReference:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFile_Error_ = "initWithFile:error:";

	private static readonly IntPtr selInitWithFile_Error_Handle = Selector.GetHandle("initWithFile:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMovie_TimeRange_Error_ = "initWithMovie:timeRange:error:";

	private static readonly IntPtr selInitWithMovie_TimeRange_Error_Handle = Selector.GetHandle("initWithMovie:timeRange:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPasteboard_Error_ = "initWithPasteboard:error:";

	private static readonly IntPtr selInitWithPasteboard_Error_Handle = Selector.GetHandle("initWithPasteboard:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Error_ = "initWithURL:error:";

	private static readonly IntPtr selInitWithURL_Error_Handle = Selector.GetHandle("initWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEmptySegmentAt_ = "insertEmptySegmentAt:";

	private static readonly IntPtr selInsertEmptySegmentAt_Handle = Selector.GetHandle("insertEmptySegmentAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfMovie_FromRange_ScaledToRange_ = "insertSegmentOfMovie:fromRange:scaledToRange:";

	private static readonly IntPtr selInsertSegmentOfMovie_FromRange_ScaledToRange_Handle = Selector.GetHandle("insertSegmentOfMovie:fromRange:scaledToRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfMovie_TimeRange_AtTime_ = "insertSegmentOfMovie:timeRange:atTime:";

	private static readonly IntPtr selInsertSegmentOfMovie_TimeRange_AtTime_Handle = Selector.GetHandle("insertSegmentOfMovie:timeRange:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfTrack_FromRange_ScaledToRange_ = "insertSegmentOfTrack:fromRange:scaledToRange:";

	private static readonly IntPtr selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle = Selector.GetHandle("insertSegmentOfTrack:fromRange:scaledToRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfTrack_TimeRange_AtTime_ = "insertSegmentOfTrack:timeRange:atTime:";

	private static readonly IntPtr selInsertSegmentOfTrack_TimeRange_AtTime_Handle = Selector.GetHandle("insertSegmentOfTrack:timeRange:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIdling = "isIdling";

	private static readonly IntPtr selIsIdlingHandle = Selector.GetHandle("isIdling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovie = "movie";

	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieAttributes = "movieAttributes";

	private static readonly IntPtr selMovieAttributesHandle = Selector.GetHandle("movieAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieFileTypes_ = "movieFileTypes:";

	private static readonly IntPtr selMovieFileTypes_Handle = Selector.GetHandle("movieFileTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieFormatRepresentation = "movieFormatRepresentation";

	private static readonly IntPtr selMovieFormatRepresentationHandle = Selector.GetHandle("movieFormatRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieNamed_Error_ = "movieNamed:error:";

	private static readonly IntPtr selMovieNamed_Error_Handle = Selector.GetHandle("movieNamed:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieTypesWithOptions_ = "movieTypesWithOptions:";

	private static readonly IntPtr selMovieTypesWithOptions_Handle = Selector.GetHandle("movieTypesWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieUnfilteredFileTypes = "movieUnfilteredFileTypes";

	private static readonly IntPtr selMovieUnfilteredFileTypesHandle = Selector.GetHandle("movieUnfilteredFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieUnfilteredPasteboardTypes = "movieUnfilteredPasteboardTypes";

	private static readonly IntPtr selMovieUnfilteredPasteboardTypesHandle = Selector.GetHandle("movieUnfilteredPasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithAttributes_Error_ = "movieWithAttributes:error:";

	private static readonly IntPtr selMovieWithAttributes_Error_Handle = Selector.GetHandle("movieWithAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithData_Error_ = "movieWithData:error:";

	private static readonly IntPtr selMovieWithData_Error_Handle = Selector.GetHandle("movieWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithFile_Error_ = "movieWithFile:error:";

	private static readonly IntPtr selMovieWithFile_Error_Handle = Selector.GetHandle("movieWithFile:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithPasteboard_Error_ = "movieWithPasteboard:error:";

	private static readonly IntPtr selMovieWithPasteboard_Error_Handle = Selector.GetHandle("movieWithPasteboard:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithTimeRange_Error_ = "movieWithTimeRange:error:";

	private static readonly IntPtr selMovieWithTimeRange_Error_Handle = Selector.GetHandle("movieWithTimeRange:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieWithURL_Error_ = "movieWithURL:error:";

	private static readonly IntPtr selMovieWithURL_Error_Handle = Selector.GetHandle("movieWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMuted = "muted";

	private static readonly IntPtr selMutedHandle = Selector.GetHandle("muted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosterImage = "posterImage";

	private static readonly IntPtr selPosterImageHandle = Selector.GetHandle("posterImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveApertureModeDimensions = "removeApertureModeDimensions";

	private static readonly IntPtr selRemoveApertureModeDimensionsHandle = Selector.GetHandle("removeApertureModeDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChapters = "removeChapters";

	private static readonly IntPtr selRemoveChaptersHandle = Selector.GetHandle("removeChapters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrack_ = "removeTrack:";

	private static readonly IntPtr selRemoveTrack_Handle = Selector.GetHandle("removeTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceSelectionWithSelectionFromMovie_ = "replaceSelectionWithSelectionFromMovie:";

	private static readonly IntPtr selReplaceSelectionWithSelectionFromMovie_Handle = Selector.GetHandle("replaceSelectionWithSelectionFromMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleSegment_NewDuration_ = "scaleSegment:newDuration:";

	private static readonly IntPtr selScaleSegment_NewDuration_Handle = Selector.GetHandle("scaleSegment:newDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionDuration = "selectionDuration";

	private static readonly IntPtr selSelectionDurationHandle = Selector.GetHandle("selectionDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionEnd = "selectionEnd";

	private static readonly IntPtr selSelectionEndHandle = Selector.GetHandle("selectionEnd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionStart = "selectionStart";

	private static readonly IntPtr selSelectionStartHandle = Selector.GetHandle("selectionStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentTime_ = "setCurrentTime:";

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovieAttributes_ = "setMovieAttributes:";

	private static readonly IntPtr selSetMovieAttributes_Handle = Selector.GetHandle("setMovieAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMuted_ = "setMuted:";

	private static readonly IntPtr selSetMuted_Handle = Selector.GetHandle("setMuted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelection_ = "setSelection:";

	private static readonly IntPtr selSetSelection_Handle = Selector.GetHandle("setSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTimeOfChapter_ = "startTimeOfChapter:";

	private static readonly IntPtr selStartTimeOfChapter_Handle = Selector.GetHandle("startTimeOfChapter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepBackward = "stepBackward";

	private static readonly IntPtr selStepBackwardHandle = Selector.GetHandle("stepBackward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepForward = "stepForward";

	private static readonly IntPtr selStepForwardHandle = Selector.GetHandle("stepForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracksOfMediaType_ = "tracksOfMediaType:";

	private static readonly IntPtr selTracksOfMediaType_Handle = Selector.GetHandle("tracksOfMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateMovieFile = "updateMovieFile";

	private static readonly IntPtr selUpdateMovieFileHandle = Selector.GetHandle("updateMovieFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_WithAttributes_ = "writeToFile:withAttributes:";

	private static readonly IntPtr selWriteToFile_WithAttributes_Handle = Selector.GetHandle("writeToFile:withAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_WithAttributes_Error_ = "writeToFile:withAttributes:error:";

	private static readonly IntPtr selWriteToFile_WithAttributes_Error_Handle = Selector.GetHandle("writeToFile:withAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTMovie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActiveSegmentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeClassic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeClean;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeEncodedPixels;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApertureModeProduction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AskUnresolvedDataRefsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAlternatesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterListDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterStartTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterTargetTrackAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CloseWindowRequestNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CopyrightAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentSizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataReferenceAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataSizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DelegateAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayNameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DontInteractWithUserAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DurationAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EditabilityDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EditableAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EditedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnterFullScreenRequestNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExitFullScreenRequestNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileNameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOffsetAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageDeinterlaceFields;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageHighQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageOpenGLContext;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImagePixelFormat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageRepresentationsType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageSingleField;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageTypeCGImageRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageTypeCIImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageTypeCVOpenGLTextureRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageTypeCVPixelBufferRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameImageTypeNSImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasApertureModeDimensionsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasAudioAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasDurationAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasVideoAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageCodecQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageCodecType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsActiveAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsInteractiveAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsLinearAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsSteppableAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyExport;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyExportManufacturer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyExportSettings;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyExportType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyFlatten;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoadStateAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoadStateDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoopModeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoopsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoopsBackAndForthAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MessageNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MessageStringPostedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModificationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MutedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NaturalSizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenAsyncOKAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PasteboardAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PasteboardType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaysAllFramesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaysSelectionOnlyAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PosterTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredMutedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredRateAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredVolumeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreviewModeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreviewRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RateAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RateChangesPreservePitchAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RateDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RateDidChangeNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResolveDataRefsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StatusCodeNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StatusFlagsNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StatusStringNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StatusStringPostedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TargetIDNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TargetNameNotificationParameter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeScaleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _URLAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UneditableException;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanUpdateMovieFile
	{
		[Export("canUpdateMovieFile")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanUpdateMovieFileHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanUpdateMovieFileHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ChapterCount
	{
		[Export("chapterCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selChapterCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selChapterCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage CurrentFrameImage
	{
		[Export("currentFrameImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentFrameImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentFrameImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime CurrentTime
	{
		[Export("currentTime")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selCurrentTimeHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentTimeHandle);
			}
			return retval;
		}
		[Export("setCurrentTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_QTTime(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_QTTime(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime Duration
	{
		[Export("duration")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasChapters
	{
		[Export("hasChapters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasChaptersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChaptersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Idling
	{
		[Export("isIdling")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIdlingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIdlingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie Movie
	{
		[Export("movie")]
		get
		{
			return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary MovieAttributes
	{
		[Export("movieAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieAttributesHandle));
		}
		[Export("setMovieAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovieAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovieAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Muted
	{
		[Export("muted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMutedHandle);
		}
		[Export("setMuted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMuted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMuted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage PosterImage
	{
		[Export("posterImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selPosterImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPosterImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
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

	[Field("QTMovieActiveSegmentAttribute", "QTKit")]
	public static NSString ActiveSegmentAttribute
	{
		get
		{
			if (_ActiveSegmentAttribute == null)
			{
				_ActiveSegmentAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieActiveSegmentAttribute");
			}
			return _ActiveSegmentAttribute;
		}
	}

	[Field("QTMovieApertureModeAttribute", "QTKit")]
	public static NSString ApertureModeAttribute
	{
		get
		{
			if (_ApertureModeAttribute == null)
			{
				_ApertureModeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeAttribute");
			}
			return _ApertureModeAttribute;
		}
	}

	[Field("QTMovieApertureModeClassic", "QTKit")]
	public static NSString ApertureModeClassic
	{
		get
		{
			if (_ApertureModeClassic == null)
			{
				_ApertureModeClassic = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeClassic");
			}
			return _ApertureModeClassic;
		}
	}

	[Field("QTMovieApertureModeClean", "QTKit")]
	public static NSString ApertureModeClean
	{
		get
		{
			if (_ApertureModeClean == null)
			{
				_ApertureModeClean = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeClean");
			}
			return _ApertureModeClean;
		}
	}

	[Field("QTMovieApertureModeDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveApertureModeDidChange helper method instead.")]
	public static NSString ApertureModeDidChangeNotification
	{
		get
		{
			if (_ApertureModeDidChangeNotification == null)
			{
				_ApertureModeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeDidChangeNotification");
			}
			return _ApertureModeDidChangeNotification;
		}
	}

	[Field("QTMovieApertureModeEncodedPixels", "QTKit")]
	public static NSString ApertureModeEncodedPixels
	{
		get
		{
			if (_ApertureModeEncodedPixels == null)
			{
				_ApertureModeEncodedPixels = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeEncodedPixels");
			}
			return _ApertureModeEncodedPixels;
		}
	}

	[Field("QTMovieApertureModeProduction", "QTKit")]
	public static NSString ApertureModeProduction
	{
		get
		{
			if (_ApertureModeProduction == null)
			{
				_ApertureModeProduction = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieApertureModeProduction");
			}
			return _ApertureModeProduction;
		}
	}

	[Field("QTMovieAskUnresolvedDataRefsAttribute", "QTKit")]
	public static NSString AskUnresolvedDataRefsAttribute
	{
		get
		{
			if (_AskUnresolvedDataRefsAttribute == null)
			{
				_AskUnresolvedDataRefsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieAskUnresolvedDataRefsAttribute");
			}
			return _AskUnresolvedDataRefsAttribute;
		}
	}

	[Field("QTMovieAutoAlternatesAttribute", "QTKit")]
	public static NSString AutoAlternatesAttribute
	{
		get
		{
			if (_AutoAlternatesAttribute == null)
			{
				_AutoAlternatesAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieAutoAlternatesAttribute");
			}
			return _AutoAlternatesAttribute;
		}
	}

	[Field("QTMovieChapterDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveChapterDidChange helper method instead.")]
	public static NSString ChapterDidChangeNotification
	{
		get
		{
			if (_ChapterDidChangeNotification == null)
			{
				_ChapterDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieChapterDidChangeNotification");
			}
			return _ChapterDidChangeNotification;
		}
	}

	[Field("QTMovieChapterListDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveChapterListDidChange helper method instead.")]
	public static NSString ChapterListDidChangeNotification
	{
		get
		{
			if (_ChapterListDidChangeNotification == null)
			{
				_ChapterListDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieChapterListDidChangeNotification");
			}
			return _ChapterListDidChangeNotification;
		}
	}

	[Field("QTMovieChapterName", "QTKit")]
	public static NSString ChapterName
	{
		get
		{
			if (_ChapterName == null)
			{
				_ChapterName = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieChapterName");
			}
			return _ChapterName;
		}
	}

	[Field("QTMovieChapterStartTime", "QTKit")]
	public static NSString ChapterStartTime
	{
		get
		{
			if (_ChapterStartTime == null)
			{
				_ChapterStartTime = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieChapterStartTime");
			}
			return _ChapterStartTime;
		}
	}

	[Field("QTMovieChapterTargetTrackAttribute", "QTKit")]
	public static NSString ChapterTargetTrackAttribute
	{
		get
		{
			if (_ChapterTargetTrackAttribute == null)
			{
				_ChapterTargetTrackAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieChapterTargetTrackAttribute");
			}
			return _ChapterTargetTrackAttribute;
		}
	}

	[Field("QTMovieCloseWindowRequestNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveCloseWindowRequest helper method instead.")]
	public static NSString CloseWindowRequestNotification
	{
		get
		{
			if (_CloseWindowRequestNotification == null)
			{
				_CloseWindowRequestNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieCloseWindowRequestNotification");
			}
			return _CloseWindowRequestNotification;
		}
	}

	[Field("QTMovieCopyrightAttribute", "QTKit")]
	public static NSString CopyrightAttribute
	{
		get
		{
			if (_CopyrightAttribute == null)
			{
				_CopyrightAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieCopyrightAttribute");
			}
			return _CopyrightAttribute;
		}
	}

	[Field("QTMovieCreationTimeAttribute", "QTKit")]
	public static NSString CreationTimeAttribute
	{
		get
		{
			if (_CreationTimeAttribute == null)
			{
				_CreationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieCreationTimeAttribute");
			}
			return _CreationTimeAttribute;
		}
	}

	[Field("QTMovieCurrentSizeAttribute", "QTKit")]
	public static NSString CurrentSizeAttribute
	{
		get
		{
			if (_CurrentSizeAttribute == null)
			{
				_CurrentSizeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieCurrentSizeAttribute");
			}
			return _CurrentSizeAttribute;
		}
	}

	[Field("QTMovieCurrentTimeAttribute", "QTKit")]
	public static NSString CurrentTimeAttribute
	{
		get
		{
			if (_CurrentTimeAttribute == null)
			{
				_CurrentTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieCurrentTimeAttribute");
			}
			return _CurrentTimeAttribute;
		}
	}

	[Field("QTMovieDataAttribute", "QTKit")]
	public static NSString DataAttribute
	{
		get
		{
			if (_DataAttribute == null)
			{
				_DataAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDataAttribute");
			}
			return _DataAttribute;
		}
	}

	[Field("QTMovieDataReferenceAttribute", "QTKit")]
	public static NSString DataReferenceAttribute
	{
		get
		{
			if (_DataReferenceAttribute == null)
			{
				_DataReferenceAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDataReferenceAttribute");
			}
			return _DataReferenceAttribute;
		}
	}

	[Field("QTMovieDataSizeAttribute", "QTKit")]
	public static NSString DataSizeAttribute
	{
		get
		{
			if (_DataSizeAttribute == null)
			{
				_DataSizeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDataSizeAttribute");
			}
			return _DataSizeAttribute;
		}
	}

	[Field("QTMovieDelegateAttribute", "QTKit")]
	public static NSString DelegateAttribute
	{
		get
		{
			if (_DelegateAttribute == null)
			{
				_DelegateAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDelegateAttribute");
			}
			return _DelegateAttribute;
		}
	}

	[Field("QTMovieDidEndNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveDidEnd helper method instead.")]
	public static NSString DidEndNotification
	{
		get
		{
			if (_DidEndNotification == null)
			{
				_DidEndNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDidEndNotification");
			}
			return _DidEndNotification;
		}
	}

	[Field("QTMovieDisplayNameAttribute", "QTKit")]
	public static NSString DisplayNameAttribute
	{
		get
		{
			if (_DisplayNameAttribute == null)
			{
				_DisplayNameAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDisplayNameAttribute");
			}
			return _DisplayNameAttribute;
		}
	}

	[Field("QTMovieDontInteractWithUserAttribute", "QTKit")]
	public static NSString DontInteractWithUserAttribute
	{
		get
		{
			if (_DontInteractWithUserAttribute == null)
			{
				_DontInteractWithUserAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDontInteractWithUserAttribute");
			}
			return _DontInteractWithUserAttribute;
		}
	}

	[Field("QTMovieDurationAttribute", "QTKit")]
	public static NSString DurationAttribute
	{
		get
		{
			if (_DurationAttribute == null)
			{
				_DurationAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieDurationAttribute");
			}
			return _DurationAttribute;
		}
	}

	[Field("QTMovieEditabilityDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveEditabilityDidChange helper method instead.")]
	public static NSString EditabilityDidChangeNotification
	{
		get
		{
			if (_EditabilityDidChangeNotification == null)
			{
				_EditabilityDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieEditabilityDidChangeNotification");
			}
			return _EditabilityDidChangeNotification;
		}
	}

	[Field("QTMovieEditableAttribute", "QTKit")]
	public static NSString EditableAttribute
	{
		get
		{
			if (_EditableAttribute == null)
			{
				_EditableAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieEditableAttribute");
			}
			return _EditableAttribute;
		}
	}

	[Field("QTMovieEditedNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveEdited helper method instead.")]
	public static NSString EditedNotification
	{
		get
		{
			if (_EditedNotification == null)
			{
				_EditedNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieEditedNotification");
			}
			return _EditedNotification;
		}
	}

	[Field("QTMovieEnterFullScreenRequestNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveEnterFullScreenRequest helper method instead.")]
	public static NSString EnterFullScreenRequestNotification
	{
		get
		{
			if (_EnterFullScreenRequestNotification == null)
			{
				_EnterFullScreenRequestNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieEnterFullScreenRequestNotification");
			}
			return _EnterFullScreenRequestNotification;
		}
	}

	[Field("QTMovieExitFullScreenRequestNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveExitFullScreenRequest helper method instead.")]
	public static NSString ExitFullScreenRequestNotification
	{
		get
		{
			if (_ExitFullScreenRequestNotification == null)
			{
				_ExitFullScreenRequestNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieExitFullScreenRequestNotification");
			}
			return _ExitFullScreenRequestNotification;
		}
	}

	[Field("QTMovieFileNameAttribute", "QTKit")]
	public static NSString FileNameAttribute
	{
		get
		{
			if (_FileNameAttribute == null)
			{
				_FileNameAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFileNameAttribute");
			}
			return _FileNameAttribute;
		}
	}

	[Field("QTMovieFileOffsetAttribute", "QTKit")]
	public static NSString FileOffsetAttribute
	{
		get
		{
			if (_FileOffsetAttribute == null)
			{
				_FileOffsetAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFileOffsetAttribute");
			}
			return _FileOffsetAttribute;
		}
	}

	[Field("QTMovieFrameImageDeinterlaceFields", "QTKit")]
	public static NSString FrameImageDeinterlaceFields
	{
		get
		{
			if (_FrameImageDeinterlaceFields == null)
			{
				_FrameImageDeinterlaceFields = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageDeinterlaceFields");
			}
			return _FrameImageDeinterlaceFields;
		}
	}

	[Field("QTMovieFrameImageHighQuality", "QTKit")]
	public static NSString FrameImageHighQuality
	{
		get
		{
			if (_FrameImageHighQuality == null)
			{
				_FrameImageHighQuality = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageHighQuality");
			}
			return _FrameImageHighQuality;
		}
	}

	[Field("QTMovieFrameImageOpenGLContext", "QTKit")]
	public static NSString FrameImageOpenGLContext
	{
		get
		{
			if (_FrameImageOpenGLContext == null)
			{
				_FrameImageOpenGLContext = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageOpenGLContext");
			}
			return _FrameImageOpenGLContext;
		}
	}

	[Field("QTMovieFrameImagePixelFormat", "QTKit")]
	public static NSString FrameImagePixelFormat
	{
		get
		{
			if (_FrameImagePixelFormat == null)
			{
				_FrameImagePixelFormat = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImagePixelFormat");
			}
			return _FrameImagePixelFormat;
		}
	}

	[Field("QTMovieFrameImageRepresentationsType", "QTKit")]
	public static NSString FrameImageRepresentationsType
	{
		get
		{
			if (_FrameImageRepresentationsType == null)
			{
				_FrameImageRepresentationsType = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageRepresentationsType");
			}
			return _FrameImageRepresentationsType;
		}
	}

	[Field("QTMovieFrameImageSingleField", "QTKit")]
	public static NSString FrameImageSingleField
	{
		get
		{
			if (_FrameImageSingleField == null)
			{
				_FrameImageSingleField = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageSingleField");
			}
			return _FrameImageSingleField;
		}
	}

	[Field("QTMovieFrameImageSize", "QTKit")]
	public static NSString FrameImageSize
	{
		get
		{
			if (_FrameImageSize == null)
			{
				_FrameImageSize = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageSize");
			}
			return _FrameImageSize;
		}
	}

	[Field("QTMovieFrameImageType", "QTKit")]
	public static NSString FrameImageType
	{
		get
		{
			if (_FrameImageType == null)
			{
				_FrameImageType = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageType");
			}
			return _FrameImageType;
		}
	}

	[Field("QTMovieFrameImageTypeCGImageRef", "QTKit")]
	public static NSString FrameImageTypeCGImageRef
	{
		get
		{
			if (_FrameImageTypeCGImageRef == null)
			{
				_FrameImageTypeCGImageRef = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageTypeCGImageRef");
			}
			return _FrameImageTypeCGImageRef;
		}
	}

	[Field("QTMovieFrameImageTypeCIImage", "QTKit")]
	public static NSString FrameImageTypeCIImage
	{
		get
		{
			if (_FrameImageTypeCIImage == null)
			{
				_FrameImageTypeCIImage = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageTypeCIImage");
			}
			return _FrameImageTypeCIImage;
		}
	}

	[Field("QTMovieFrameImageTypeCVOpenGLTextureRef", "QTKit")]
	public static NSString FrameImageTypeCVOpenGLTextureRef
	{
		get
		{
			if (_FrameImageTypeCVOpenGLTextureRef == null)
			{
				_FrameImageTypeCVOpenGLTextureRef = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageTypeCVOpenGLTextureRef");
			}
			return _FrameImageTypeCVOpenGLTextureRef;
		}
	}

	[Field("QTMovieFrameImageTypeCVPixelBufferRef", "QTKit")]
	public static NSString FrameImageTypeCVPixelBufferRef
	{
		get
		{
			if (_FrameImageTypeCVPixelBufferRef == null)
			{
				_FrameImageTypeCVPixelBufferRef = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageTypeCVPixelBufferRef");
			}
			return _FrameImageTypeCVPixelBufferRef;
		}
	}

	[Field("QTMovieFrameImageTypeNSImage", "QTKit")]
	public static NSString FrameImageTypeNSImage
	{
		get
		{
			if (_FrameImageTypeNSImage == null)
			{
				_FrameImageTypeNSImage = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFrameImageTypeNSImage");
			}
			return _FrameImageTypeNSImage;
		}
	}

	[Field("QTMovieHasApertureModeDimensionsAttribute", "QTKit")]
	public static NSString HasApertureModeDimensionsAttribute
	{
		get
		{
			if (_HasApertureModeDimensionsAttribute == null)
			{
				_HasApertureModeDimensionsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieHasApertureModeDimensionsAttribute");
			}
			return _HasApertureModeDimensionsAttribute;
		}
	}

	[Field("QTMovieHasAudioAttribute", "QTKit")]
	public static NSString HasAudioAttribute
	{
		get
		{
			if (_HasAudioAttribute == null)
			{
				_HasAudioAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieHasAudioAttribute");
			}
			return _HasAudioAttribute;
		}
	}

	[Field("QTMovieHasDurationAttribute", "QTKit")]
	public static NSString HasDurationAttribute
	{
		get
		{
			if (_HasDurationAttribute == null)
			{
				_HasDurationAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieHasDurationAttribute");
			}
			return _HasDurationAttribute;
		}
	}

	[Field("QTMovieHasVideoAttribute", "QTKit")]
	public static NSString HasVideoAttribute
	{
		get
		{
			if (_HasVideoAttribute == null)
			{
				_HasVideoAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieHasVideoAttribute");
			}
			return _HasVideoAttribute;
		}
	}

	[Field("QTAddImageCodecQuality", "QTKit")]
	internal static NSString ImageCodecQuality
	{
		get
		{
			if (_ImageCodecQuality == null)
			{
				_ImageCodecQuality = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTAddImageCodecQuality");
			}
			return _ImageCodecQuality;
		}
	}

	[Field("QTAddImageCodecType", "QTKit")]
	internal static NSString ImageCodecType
	{
		get
		{
			if (_ImageCodecType == null)
			{
				_ImageCodecType = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTAddImageCodecType");
			}
			return _ImageCodecType;
		}
	}

	[Field("QTMovieIsActiveAttribute", "QTKit")]
	public static NSString IsActiveAttribute
	{
		get
		{
			if (_IsActiveAttribute == null)
			{
				_IsActiveAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieIsActiveAttribute");
			}
			return _IsActiveAttribute;
		}
	}

	[Field("QTMovieIsInteractiveAttribute", "QTKit")]
	public static NSString IsInteractiveAttribute
	{
		get
		{
			if (_IsInteractiveAttribute == null)
			{
				_IsInteractiveAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieIsInteractiveAttribute");
			}
			return _IsInteractiveAttribute;
		}
	}

	[Field("QTMovieIsLinearAttribute", "QTKit")]
	public static NSString IsLinearAttribute
	{
		get
		{
			if (_IsLinearAttribute == null)
			{
				_IsLinearAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieIsLinearAttribute");
			}
			return _IsLinearAttribute;
		}
	}

	[Field("QTMovieIsSteppableAttribute", "QTKit")]
	public static NSString IsSteppableAttribute
	{
		get
		{
			if (_IsSteppableAttribute == null)
			{
				_IsSteppableAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieIsSteppableAttribute");
			}
			return _IsSteppableAttribute;
		}
	}

	[Field("QTMovieExport", "QTKit")]
	internal static NSString KeyExport
	{
		get
		{
			if (_KeyExport == null)
			{
				_KeyExport = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieExport");
			}
			return _KeyExport;
		}
	}

	[Field("QTMovieExportManufacturer", "QTKit")]
	internal static NSString KeyExportManufacturer
	{
		get
		{
			if (_KeyExportManufacturer == null)
			{
				_KeyExportManufacturer = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieExportManufacturer");
			}
			return _KeyExportManufacturer;
		}
	}

	[Field("QTMovieExportSettings", "QTKit")]
	internal static NSString KeyExportSettings
	{
		get
		{
			if (_KeyExportSettings == null)
			{
				_KeyExportSettings = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieExportSettings");
			}
			return _KeyExportSettings;
		}
	}

	[Field("QTMovieExportType", "QTKit")]
	internal static NSString KeyExportType
	{
		get
		{
			if (_KeyExportType == null)
			{
				_KeyExportType = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieExportType");
			}
			return _KeyExportType;
		}
	}

	[Field("QTMovieFlatten", "QTKit")]
	internal static NSString KeyFlatten
	{
		get
		{
			if (_KeyFlatten == null)
			{
				_KeyFlatten = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieFlatten");
			}
			return _KeyFlatten;
		}
	}

	[Field("QTMovieLoadStateAttribute", "QTKit")]
	public static NSString LoadStateAttribute
	{
		get
		{
			if (_LoadStateAttribute == null)
			{
				_LoadStateAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieLoadStateAttribute");
			}
			return _LoadStateAttribute;
		}
	}

	[Field("QTMovieLoadStateDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveLoadStateDidChange helper method instead.")]
	public static NSString LoadStateDidChangeNotification
	{
		get
		{
			if (_LoadStateDidChangeNotification == null)
			{
				_LoadStateDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieLoadStateDidChangeNotification");
			}
			return _LoadStateDidChangeNotification;
		}
	}

	[Field("QTMovieLoopModeDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveLoopModeDidChange helper method instead.")]
	public static NSString LoopModeDidChangeNotification
	{
		get
		{
			if (_LoopModeDidChangeNotification == null)
			{
				_LoopModeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieLoopModeDidChangeNotification");
			}
			return _LoopModeDidChangeNotification;
		}
	}

	[Field("QTMovieLoopsAttribute", "QTKit")]
	public static NSString LoopsAttribute
	{
		get
		{
			if (_LoopsAttribute == null)
			{
				_LoopsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieLoopsAttribute");
			}
			return _LoopsAttribute;
		}
	}

	[Field("QTMovieLoopsBackAndForthAttribute", "QTKit")]
	public static NSString LoopsBackAndForthAttribute
	{
		get
		{
			if (_LoopsBackAndForthAttribute == null)
			{
				_LoopsBackAndForthAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieLoopsBackAndForthAttribute");
			}
			return _LoopsBackAndForthAttribute;
		}
	}

	[Field("QTMovieMessageNotificationParameter", "QTKit")]
	public static NSString MessageNotificationParameter
	{
		get
		{
			if (_MessageNotificationParameter == null)
			{
				_MessageNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieMessageNotificationParameter");
			}
			return _MessageNotificationParameter;
		}
	}

	[Field("QTMovieMessageStringPostedNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveMessageStringPosted helper method instead.")]
	public static NSString MessageStringPostedNotification
	{
		get
		{
			if (_MessageStringPostedNotification == null)
			{
				_MessageStringPostedNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieMessageStringPostedNotification");
			}
			return _MessageStringPostedNotification;
		}
	}

	[Field("QTMovieModificationTimeAttribute", "QTKit")]
	public static NSString ModificationTimeAttribute
	{
		get
		{
			if (_ModificationTimeAttribute == null)
			{
				_ModificationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieModificationTimeAttribute");
			}
			return _ModificationTimeAttribute;
		}
	}

	[Field("QTMovieMutedAttribute", "QTKit")]
	public static NSString MutedAttribute
	{
		get
		{
			if (_MutedAttribute == null)
			{
				_MutedAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieMutedAttribute");
			}
			return _MutedAttribute;
		}
	}

	[Field("QTMovieNaturalSizeAttribute", "QTKit")]
	public static NSString NaturalSizeAttribute
	{
		get
		{
			if (_NaturalSizeAttribute == null)
			{
				_NaturalSizeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieNaturalSizeAttribute");
			}
			return _NaturalSizeAttribute;
		}
	}

	[Field("QTMovieOpenAsyncOKAttribute", "QTKit")]
	public static NSString OpenAsyncOKAttribute
	{
		get
		{
			if (_OpenAsyncOKAttribute == null)
			{
				_OpenAsyncOKAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieOpenAsyncOKAttribute");
			}
			return _OpenAsyncOKAttribute;
		}
	}

	[Field("QTMoviePasteboardAttribute", "QTKit")]
	public static NSString PasteboardAttribute
	{
		get
		{
			if (_PasteboardAttribute == null)
			{
				_PasteboardAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePasteboardAttribute");
			}
			return _PasteboardAttribute;
		}
	}

	[Field("QTMoviePasteboardType", "QTKit")]
	public static NSString PasteboardType
	{
		get
		{
			if (_PasteboardType == null)
			{
				_PasteboardType = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePasteboardType");
			}
			return _PasteboardType;
		}
	}

	[Field("QTMoviePlaysAllFramesAttribute", "QTKit")]
	public static NSString PlaysAllFramesAttribute
	{
		get
		{
			if (_PlaysAllFramesAttribute == null)
			{
				_PlaysAllFramesAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePlaysAllFramesAttribute");
			}
			return _PlaysAllFramesAttribute;
		}
	}

	[Field("QTMoviePlaysSelectionOnlyAttribute", "QTKit")]
	public static NSString PlaysSelectionOnlyAttribute
	{
		get
		{
			if (_PlaysSelectionOnlyAttribute == null)
			{
				_PlaysSelectionOnlyAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePlaysSelectionOnlyAttribute");
			}
			return _PlaysSelectionOnlyAttribute;
		}
	}

	[Field("QTMoviePosterTimeAttribute", "QTKit")]
	public static NSString PosterTimeAttribute
	{
		get
		{
			if (_PosterTimeAttribute == null)
			{
				_PosterTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePosterTimeAttribute");
			}
			return _PosterTimeAttribute;
		}
	}

	[Field("QTMoviePreferredMutedAttribute", "QTKit")]
	public static NSString PreferredMutedAttribute
	{
		get
		{
			if (_PreferredMutedAttribute == null)
			{
				_PreferredMutedAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePreferredMutedAttribute");
			}
			return _PreferredMutedAttribute;
		}
	}

	[Field("QTMoviePreferredRateAttribute", "QTKit")]
	public static NSString PreferredRateAttribute
	{
		get
		{
			if (_PreferredRateAttribute == null)
			{
				_PreferredRateAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePreferredRateAttribute");
			}
			return _PreferredRateAttribute;
		}
	}

	[Field("QTMoviePreferredVolumeAttribute", "QTKit")]
	public static NSString PreferredVolumeAttribute
	{
		get
		{
			if (_PreferredVolumeAttribute == null)
			{
				_PreferredVolumeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePreferredVolumeAttribute");
			}
			return _PreferredVolumeAttribute;
		}
	}

	[Field("QTMoviePreviewModeAttribute", "QTKit")]
	public static NSString PreviewModeAttribute
	{
		get
		{
			if (_PreviewModeAttribute == null)
			{
				_PreviewModeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePreviewModeAttribute");
			}
			return _PreviewModeAttribute;
		}
	}

	[Field("QTMoviePreviewRangeAttribute", "QTKit")]
	public static NSString PreviewRangeAttribute
	{
		get
		{
			if (_PreviewRangeAttribute == null)
			{
				_PreviewRangeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMoviePreviewRangeAttribute");
			}
			return _PreviewRangeAttribute;
		}
	}

	[Field("QTMovieRateAttribute", "QTKit")]
	public static NSString RateAttribute
	{
		get
		{
			if (_RateAttribute == null)
			{
				_RateAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieRateAttribute");
			}
			return _RateAttribute;
		}
	}

	[Field("QTMovieRateChangesPreservePitchAttribute", "QTKit")]
	public static NSString RateChangesPreservePitchAttribute
	{
		get
		{
			if (_RateChangesPreservePitchAttribute == null)
			{
				_RateChangesPreservePitchAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieRateChangesPreservePitchAttribute");
			}
			return _RateChangesPreservePitchAttribute;
		}
	}

	[Field("QTMovieRateDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveRateDidChange helper method instead.")]
	public static NSString RateDidChangeNotification
	{
		get
		{
			if (_RateDidChangeNotification == null)
			{
				_RateDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieRateDidChangeNotification");
			}
			return _RateDidChangeNotification;
		}
	}

	[Field("QTMovieRateDidChangeNotificationParameter", "QTKit")]
	public static NSString RateDidChangeNotificationParameter
	{
		get
		{
			if (_RateDidChangeNotificationParameter == null)
			{
				_RateDidChangeNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieRateDidChangeNotificationParameter");
			}
			return _RateDidChangeNotificationParameter;
		}
	}

	[Field("QTMovieResolveDataRefsAttribute", "QTKit")]
	public static NSString ResolveDataRefsAttribute
	{
		get
		{
			if (_ResolveDataRefsAttribute == null)
			{
				_ResolveDataRefsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieResolveDataRefsAttribute");
			}
			return _ResolveDataRefsAttribute;
		}
	}

	[Field("QTMovieSelectionAttribute", "QTKit")]
	public static NSString SelectionAttribute
	{
		get
		{
			if (_SelectionAttribute == null)
			{
				_SelectionAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieSelectionAttribute");
			}
			return _SelectionAttribute;
		}
	}

	[Field("QTMovieSelectionDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveSelectionDidChange helper method instead.")]
	public static NSString SelectionDidChangeNotification
	{
		get
		{
			if (_SelectionDidChangeNotification == null)
			{
				_SelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieSelectionDidChangeNotification");
			}
			return _SelectionDidChangeNotification;
		}
	}

	[Field("QTMovieSizeDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveSizeDidChange helper method instead.")]
	public static NSString SizeDidChangeNotification
	{
		get
		{
			if (_SizeDidChangeNotification == null)
			{
				_SizeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieSizeDidChangeNotification");
			}
			return _SizeDidChangeNotification;
		}
	}

	[Field("QTMovieStatusCodeNotificationParameter", "QTKit")]
	public static NSString StatusCodeNotificationParameter
	{
		get
		{
			if (_StatusCodeNotificationParameter == null)
			{
				_StatusCodeNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieStatusCodeNotificationParameter");
			}
			return _StatusCodeNotificationParameter;
		}
	}

	[Field("QTMovieStatusFlagsNotificationParameter", "QTKit")]
	public static NSString StatusFlagsNotificationParameter
	{
		get
		{
			if (_StatusFlagsNotificationParameter == null)
			{
				_StatusFlagsNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieStatusFlagsNotificationParameter");
			}
			return _StatusFlagsNotificationParameter;
		}
	}

	[Field("QTMovieStatusStringNotificationParameter", "QTKit")]
	public static NSString StatusStringNotificationParameter
	{
		get
		{
			if (_StatusStringNotificationParameter == null)
			{
				_StatusStringNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieStatusStringNotificationParameter");
			}
			return _StatusStringNotificationParameter;
		}
	}

	[Field("QTMovieStatusStringPostedNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveStatusStringPosted helper method instead.")]
	public static NSString StatusStringPostedNotification
	{
		get
		{
			if (_StatusStringPostedNotification == null)
			{
				_StatusStringPostedNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieStatusStringPostedNotification");
			}
			return _StatusStringPostedNotification;
		}
	}

	[Field("QTMovieTargetIDNotificationParameter", "QTKit")]
	public static NSString TargetIDNotificationParameter
	{
		get
		{
			if (_TargetIDNotificationParameter == null)
			{
				_TargetIDNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieTargetIDNotificationParameter");
			}
			return _TargetIDNotificationParameter;
		}
	}

	[Field("QTMovieTargetNameNotificationParameter", "QTKit")]
	public static NSString TargetNameNotificationParameter
	{
		get
		{
			if (_TargetNameNotificationParameter == null)
			{
				_TargetNameNotificationParameter = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieTargetNameNotificationParameter");
			}
			return _TargetNameNotificationParameter;
		}
	}

	[Field("QTMovieTimeDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveTimeDidChange helper method instead.")]
	public static NSString TimeDidChangeNotification
	{
		get
		{
			if (_TimeDidChangeNotification == null)
			{
				_TimeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieTimeDidChangeNotification");
			}
			return _TimeDidChangeNotification;
		}
	}

	[Field("QTMovieTimeScaleAttribute", "QTKit")]
	public static NSString TimeScaleAttribute
	{
		get
		{
			if (_TimeScaleAttribute == null)
			{
				_TimeScaleAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieTimeScaleAttribute");
			}
			return _TimeScaleAttribute;
		}
	}

	[Field("QTMovieURLAttribute", "QTKit")]
	public static NSString URLAttribute
	{
		get
		{
			if (_URLAttribute == null)
			{
				_URLAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieURLAttribute");
			}
			return _URLAttribute;
		}
	}

	[Field("QTMovieUneditableException", "QTKit")]
	public static NSString UneditableException
	{
		get
		{
			if (_UneditableException == null)
			{
				_UneditableException = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieUneditableException");
			}
			return _UneditableException;
		}
	}

	[Field("QTMovieVolumeAttribute", "QTKit")]
	public static NSString VolumeAttribute
	{
		get
		{
			if (_VolumeAttribute == null)
			{
				_VolumeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieVolumeAttribute");
			}
			return _VolumeAttribute;
		}
	}

	[Field("QTMovieVolumeDidChangeNotification", "QTKit")]
	[Advice("Use QTMovie.Notifications.ObserveVolumeDidChange helper method instead.")]
	public static NSString VolumeDidChangeNotification
	{
		get
		{
			if (_VolumeDidChangeNotification == null)
			{
				_VolumeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMovieVolumeDidChangeNotification");
			}
			return _VolumeDidChangeNotification;
		}
	}

	public bool SaveTo(string fileName, QTMovieSaveOptions options, out NSError error)
	{
		return SaveTo(fileName, options?.ToDictionary(), out error);
	}

	public bool SaveTo(string fileName, QTMovieSaveOptions options)
	{
		return SaveTo(fileName, options?.ToDictionary());
	}

	public void AddImage(NSImage image, QTTime forDuration, QTImageAttributes attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		AddImage(image, forDuration, attributes.ToDictionary());
	}

	public QTTrack[] TracksOfMediaType(QTMediaType mediaType)
	{
		return TracksOfMediaType(QTMedia.NSStringFromQTMediaType(mediaType));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovie()
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
	public QTMovie(NSCoder coder)
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
	protected QTMovie(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTMovie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFile:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(string fileName, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fileName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithFile_Error_Handle, arg2, ref arg), "initWithFile:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithFile_Error_Handle, arg2, ref arg), "initWithFile:error:");
		}
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(NSUrl url, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Error_Handle, url.Handle, ref arg), "initWithURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Error_Handle, url.Handle, ref arg), "initWithURL:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithDataReference:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(QTDataReference dataReference, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (dataReference == null)
		{
			throw new ArgumentNullException("dataReference");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithDataReference_Error_Handle, dataReference.Handle, ref arg), "initWithDataReference:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDataReference_Error_Handle, dataReference.Handle, ref arg), "initWithDataReference:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithPasteboard:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(NSPasteboard pasteboard, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithPasteboard_Error_Handle, pasteboard.Handle, ref arg), "initWithPasteboard:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithPasteboard_Error_Handle, pasteboard.Handle, ref arg), "initWithPasteboard:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(NSData data, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithData_Error_Handle, data.Handle, ref arg), "initWithData:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_Error_Handle, data.Handle, ref arg), "initWithData:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithMovie:timeRange:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(QTMovie movie, QTTimeRange range, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_ref_IntPtr(base.Handle, selInitWithMovie_TimeRange_Error_Handle, movie.Handle, range, ref arg), "initWithMovie:timeRange:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_ref_IntPtr(base.SuperHandle, selInitWithMovie_TimeRange_Error_Handle, movie.Handle, range, ref arg), "initWithMovie:timeRange:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(NSDictionary attributes, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithAttributes_Error_Handle, attributes.Handle, ref arg), "initWithAttributes:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithAttributes_Error_Handle, attributes.Handle, ref arg), "initWithAttributes:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("movieWithTimeRange:error:")]
	[Obsolete("Use the 'MoveWithTimeRange' method instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(QTTimeRange range, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_QTTimeRange_ref_IntPtr(base.Handle, selMovieWithTimeRange_Error_Handle, range, ref arg), "movieWithTimeRange:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_QTTimeRange_ref_IntPtr(base.SuperHandle, selMovieWithTimeRange_Error_Handle, range, ref arg), "movieWithTimeRange:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initToWritableData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie(NSMutableData data, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitToWritableData_Error_Handle, data.Handle, ref arg), "initToWritableData:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitToWritableData_Error_Handle, data.Handle, ref arg), "initToWritableData:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addImage:forDuration:withAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddImage(NSImage image, QTTime duration, NSDictionary attributes)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTime_IntPtr(base.Handle, selAddImage_ForDuration_WithAttributes_Handle, image.Handle, duration, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTime_IntPtr(base.SuperHandle, selAddImage_ForDuration_WithAttributes_Handle, image.Handle, duration, attributes.Handle);
		}
	}

	[Export("appendSelectionFromMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendSelectionFromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendSelectionFromMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendSelectionFromMovie_Handle, movie.Handle);
		}
	}

	[Export("attachToCurrentThread")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AttachToCurrentThread()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAttachToCurrentThreadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAttachToCurrentThreadHandle);
	}

	[Export("autoplay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Autoplay()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAutoplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAutoplayHandle);
		}
	}

	[Export("canInitWithFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithFile(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithFile_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("canInitWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("canInitWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithURL_Handle, url.Handle);
	}

	[Export("chapterIndexForTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ChapterIndexForTime(QTTime time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_QTTime(base.Handle, selChapterIndexForTime_Handle, time);
		}
		return Messaging.nint_objc_msgSendSuper_QTTime(base.SuperHandle, selChapterIndexForTime_Handle, time);
	}

	[Export("chapters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary[] Chapters()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selChaptersHandle));
		}
		return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChaptersHandle));
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

	[Export("deleteSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteSegment(QTTimeRange segment)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selDeleteSegment_Handle, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selDeleteSegment_Handle, segment);
		}
	}

	[Export("detachFromCurrentThread")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DetachFromCurrentThread()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDetachFromCurrentThreadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDetachFromCurrentThreadHandle);
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

	[Export("enterQTKitOnThread")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EnterQTKitOnThread()
	{
		Messaging.void_objc_msgSend(class_ptr, selEnterQTKitOnThreadHandle);
	}

	[Export("enterQTKitOnThreadDisablingThreadSafetyProtection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EnterQTKitOnThreadDisablingThreadSafetyProtection()
	{
		Messaging.void_objc_msgSend(class_ptr, selEnterQTKitOnThreadDisablingThreadSafetyProtectionHandle);
	}

	[Export("exitQTKitOnThread")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ExitQTKitOnThread()
	{
		Messaging.void_objc_msgSend(class_ptr, selExitQTKitOnThreadHandle);
	}

	[Export("frameImageAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage FrameImageAtTime(QTTime time)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_QTTime(base.Handle, selFrameImageAtTime_Handle, time));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_QTTime(base.SuperHandle, selFrameImageAtTime_Handle, time));
	}

	[Export("frameImageAtTime:withAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr FrameImageAtTime(QTTime time, NSDictionary attributes, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_QTTime_IntPtr_ref_IntPtr(base.SuperHandle, selFrameImageAtTime_WithAttributes_Error_Handle, time, attributes.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_QTTime_IntPtr_ref_IntPtr(base.Handle, selFrameImageAtTime_WithAttributes_Error_Handle, time, attributes.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("movieWithAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromAttributes(NSDictionary attributes, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = IntPtr.Zero;
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieWithAttributes_Error_Handle, attributes.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromData(NSData data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieWithData_Error_Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithFile:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromFile(string fileName, out NSError error)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fileName);
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieWithFile_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieNamed:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromMovieNamed(string name, out NSError error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieNamed_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithPasteboard:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromPasteboard(NSPasteboard pasteboard, out NSError error)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = IntPtr.Zero;
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieWithPasteboard_Error_Handle, pasteboard.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("movieWithURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovie FromUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMovieWithURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("generateApertureModeDimensions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GenerateApertureModeDimensions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGenerateApertureModeDimensionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGenerateApertureModeDimensionsHandle);
		}
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("gotoBeginning")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoBeginning()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoBeginningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoBeginningHandle);
		}
	}

	[Export("gotoEnd")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoEnd()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoEndHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoEndHandle);
		}
	}

	[Export("gotoNextSelectionPoint")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoNextSelectionPoint()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoNextSelectionPointHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoNextSelectionPointHandle);
		}
	}

	[Export("gotoPosterTime")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoPosterTime()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoPosterTimeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoPosterTimeHandle);
		}
	}

	[Export("gotoPreviousSelectionPoint")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoPreviousSelectionPoint()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoPreviousSelectionPointHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoPreviousSelectionPointHandle);
		}
	}

	[Export("insertEmptySegmentAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertEmptySegmentAt(QTTimeRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selInsertEmptySegmentAt_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selInsertEmptySegmentAt_Handle, range);
		}
	}

	[Export("insertSegmentOfMovie:fromRange:scaledToRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentOfMovieFromRange(QTMovie movie, QTTimeRange srcRange, QTTimeRange dstRange)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfMovie_FromRange_ScaledToRange_Handle, movie.Handle, srcRange, dstRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfMovie_FromRange_ScaledToRange_Handle, movie.Handle, srcRange, dstRange);
		}
	}

	[Export("insertSegmentOfMovie:timeRange:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentOfMovieTimeRange(QTMovie movie, QTTimeRange range, QTTime time)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfMovie_TimeRange_AtTime_Handle, movie.Handle, range, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfMovie_TimeRange_AtTime_Handle, movie.Handle, range, time);
		}
	}

	[Export("insertSegmentOfTrack:fromRange:scaledToRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTrack InsertSegmentOfTrackFromRange(QTTrack track, QTTimeRange srcRange, QTTimeRange dstRange)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle, track.Handle, srcRange, dstRange));
		}
		return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle, track.Handle, srcRange, dstRange));
	}

	[Export("insertSegmentOfTrack:timeRange:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTrack InsertSegmentOfTrackTimeRange(QTTrack track, QTTimeRange range, QTTime time)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfTrack_TimeRange_AtTime_Handle, track.Handle, range, time));
		}
		return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfTrack_TimeRange_AtTime_Handle, track.Handle, range, time));
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("movieFileTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] MovieFileTypes(QTMovieFileTypeOptions types)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selMovieFileTypes_Handle, (uint)types));
	}

	[Export("movieFormatRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData MovieFormatRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieFormatRepresentationHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieFormatRepresentationHandle));
	}

	[Export("movieTypesWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] MovieTypesWithOptions(QTMovieFileTypeOptions types)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selMovieTypesWithOptions_Handle, (uint)types));
	}

	[Export("movieUnfilteredFileTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] MovieUnfilteredFileTypes()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieUnfilteredFileTypesHandle));
	}

	[Export("movieUnfilteredPasteboardTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] MovieUnfilteredPasteboardTypes()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieUnfilteredPasteboardTypesHandle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovie MovieWithTimeRange(QTTimeRange range, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		QTMovie nSObject = Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend_QTTimeRange_ref_IntPtr(base.Handle, selMovieWithTimeRange_Error_Handle, range, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("play")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Play()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
		}
	}

	[Export("removeApertureModeDimensions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveApertureModeDimensions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveApertureModeDimensionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveApertureModeDimensionsHandle);
		}
	}

	[Export("removeChapters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveChapters()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRemoveChaptersHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRemoveChaptersHandle);
	}

	[Export("removeTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTrack(QTTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrack_Handle, track.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrack_Handle, track.Handle);
		}
	}

	[Export("replaceSelectionWithSelectionFromMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceSelectionWithSelectionFromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithSelectionFromMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithSelectionFromMovie_Handle, movie.Handle);
		}
	}

	[Export("writeToFile:withAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveTo(string fileName, NSDictionary attributes)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToFile_WithAttributes_Handle, arg, attributes.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToFile_WithAttributes_Handle, arg, attributes.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToFile:withAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveTo(string fileName, NSDictionary attributes, out NSError error)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fileName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selWriteToFile_WithAttributes_Error_Handle, arg2, attributes.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selWriteToFile_WithAttributes_Error_Handle, arg2, attributes.Handle, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scaleSegment:newDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleSegmentNewDuration(QTTimeRange segment, QTTime newDuration)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange_QTTime(base.Handle, selScaleSegment_NewDuration_Handle, segment, newDuration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange_QTTime(base.SuperHandle, selScaleSegment_NewDuration_Handle, segment, newDuration);
		}
	}

	[Export("selectionDuration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime SelectionDuration()
	{
		QTTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selSelectionDurationHandle);
		}
		else
		{
			Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSelectionDurationHandle);
		}
		return retval;
	}

	[Export("selectionEnd")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime SelectionEnd()
	{
		QTTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selSelectionEndHandle);
		}
		else
		{
			Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSelectionEndHandle);
		}
		return retval;
	}

	[Export("selectionStart")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime SelectionStart()
	{
		QTTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selSelectionStartHandle);
		}
		else
		{
			Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSelectionStartHandle);
		}
		return retval;
	}

	[Export("setAttribute:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttribute(NSObject value, string attributeKey)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_ForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_ForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelection(QTTimeRange selection)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selSetSelection_Handle, selection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selSetSelection_Handle, selection);
		}
	}

	[Export("startTimeOfChapter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime StartTimeOfChapter(nint chapterIndex)
	{
		QTTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.QTTime_objc_msgSend_stret_nint(out retval, base.Handle, selStartTimeOfChapter_Handle, chapterIndex);
		}
		else
		{
			Messaging.QTTime_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selStartTimeOfChapter_Handle, chapterIndex);
		}
		return retval;
	}

	[Export("stepBackward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StepBackward()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStepBackwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStepBackwardHandle);
		}
	}

	[Export("stepForward")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StepForward()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStepForwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStepForwardHandle);
		}
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	[Export("tracksOfMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTrack[] TracksOfMediaType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		QTTrack[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksOfMediaType_Handle, arg)) : NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksOfMediaType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("updateMovieFile")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateMovieFile()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUpdateMovieFileHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUpdateMovieFileHandle);
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
