using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMovie", true)]
public class QTMovie : NSObject
{
	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr selMutedHandle = Selector.GetHandle("muted");

	private static readonly IntPtr selSetMuted_Handle = Selector.GetHandle("setMuted:");

	private static readonly IntPtr selMovieAttributesHandle = Selector.GetHandle("movieAttributes");

	private static readonly IntPtr selSetMovieAttributes_Handle = Selector.GetHandle("setMovieAttributes:");

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	private static readonly IntPtr selPosterImageHandle = Selector.GetHandle("posterImage");

	private static readonly IntPtr selCurrentFrameImageHandle = Selector.GetHandle("currentFrameImage");

	private static readonly IntPtr selCanUpdateMovieFileHandle = Selector.GetHandle("canUpdateMovieFile");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selIsIdlingHandle = Selector.GetHandle("isIdling");

	private static readonly IntPtr selHasChaptersHandle = Selector.GetHandle("hasChapters");

	private static readonly IntPtr selChapterCountHandle = Selector.GetHandle("chapterCount");

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	private static readonly IntPtr selCanInitWithFile_Handle = Selector.GetHandle("canInitWithFile:");

	private static readonly IntPtr selCanInitWithURL_Handle = Selector.GetHandle("canInitWithURL:");

	private static readonly IntPtr selMovieFileTypes_Handle = Selector.GetHandle("movieFileTypes:");

	private static readonly IntPtr selMovieUnfilteredFileTypesHandle = Selector.GetHandle("movieUnfilteredFileTypes");

	private static readonly IntPtr selMovieUnfilteredPasteboardTypesHandle = Selector.GetHandle("movieUnfilteredPasteboardTypes");

	private static readonly IntPtr selMovieTypesWithOptions_Handle = Selector.GetHandle("movieTypesWithOptions:");

	private static readonly IntPtr selMovieWithFileError_Handle = Selector.GetHandle("movieWithFile:error:");

	private static readonly IntPtr selMovieWithURLError_Handle = Selector.GetHandle("movieWithURL:error:");

	private static readonly IntPtr selMovieWithPasteboardError_Handle = Selector.GetHandle("movieWithPasteboard:error:");

	private static readonly IntPtr selMovieWithDataError_Handle = Selector.GetHandle("movieWithData:error:");

	private static readonly IntPtr selMovieWithAttributesError_Handle = Selector.GetHandle("movieWithAttributes:error:");

	private static readonly IntPtr selMovieNamedError_Handle = Selector.GetHandle("movieNamed:error:");

	private static readonly IntPtr selInitWithFileError_Handle = Selector.GetHandle("initWithFile:error:");

	private static readonly IntPtr selInitWithURLError_Handle = Selector.GetHandle("initWithURL:error:");

	private static readonly IntPtr selInitWithDataReferenceError_Handle = Selector.GetHandle("initWithDataReference:error:");

	private static readonly IntPtr selInitWithPasteboardError_Handle = Selector.GetHandle("initWithPasteboard:error:");

	private static readonly IntPtr selInitWithDataError_Handle = Selector.GetHandle("initWithData:error:");

	private static readonly IntPtr selInitWithMovieTimeRangeError_Handle = Selector.GetHandle("initWithMovie:timeRange:error:");

	private static readonly IntPtr selInitWithAttributesError_Handle = Selector.GetHandle("initWithAttributes:error:");

	private static readonly IntPtr selMovieWithTimeRangeError_Handle = Selector.GetHandle("movieWithTimeRange:error:");

	private static readonly IntPtr selInitToWritableDataError_Handle = Selector.GetHandle("initToWritableData:error:");

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selSetAttributeForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	private static readonly IntPtr selTracksOfMediaType_Handle = Selector.GetHandle("tracksOfMediaType:");

	private static readonly IntPtr selFrameImageAtTime_Handle = Selector.GetHandle("frameImageAtTime:");

	private static readonly IntPtr selFrameImageAtTimeWithAttributesError_Handle = Selector.GetHandle("frameImageAtTime:withAttributes:error:");

	private static readonly IntPtr selMovieFormatRepresentationHandle = Selector.GetHandle("movieFormatRepresentation");

	private static readonly IntPtr selWriteToFileWithAttributes_Handle = Selector.GetHandle("writeToFile:withAttributes:");

	private static readonly IntPtr selWriteToFileWithAttributesError_Handle = Selector.GetHandle("writeToFile:withAttributes:error:");

	private static readonly IntPtr selUpdateMovieFileHandle = Selector.GetHandle("updateMovieFile");

	private static readonly IntPtr selAutoplayHandle = Selector.GetHandle("autoplay");

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr selGotoBeginningHandle = Selector.GetHandle("gotoBeginning");

	private static readonly IntPtr selGotoEndHandle = Selector.GetHandle("gotoEnd");

	private static readonly IntPtr selGotoNextSelectionPointHandle = Selector.GetHandle("gotoNextSelectionPoint");

	private static readonly IntPtr selGotoPreviousSelectionPointHandle = Selector.GetHandle("gotoPreviousSelectionPoint");

	private static readonly IntPtr selGotoPosterTimeHandle = Selector.GetHandle("gotoPosterTime");

	private static readonly IntPtr selStepForwardHandle = Selector.GetHandle("stepForward");

	private static readonly IntPtr selStepBackwardHandle = Selector.GetHandle("stepBackward");

	private static readonly IntPtr selSetSelection_Handle = Selector.GetHandle("setSelection:");

	private static readonly IntPtr selSelectionStartHandle = Selector.GetHandle("selectionStart");

	private static readonly IntPtr selSelectionEndHandle = Selector.GetHandle("selectionEnd");

	private static readonly IntPtr selSelectionDurationHandle = Selector.GetHandle("selectionDuration");

	private static readonly IntPtr selReplaceSelectionWithSelectionFromMovie_Handle = Selector.GetHandle("replaceSelectionWithSelectionFromMovie:");

	private static readonly IntPtr selAppendSelectionFromMovie_Handle = Selector.GetHandle("appendSelectionFromMovie:");

	private static readonly IntPtr selInsertSegmentOfMovieTimeRangeAtTime_Handle = Selector.GetHandle("insertSegmentOfMovie:timeRange:atTime:");

	private static readonly IntPtr selInsertSegmentOfMovieFromRangeScaledToRange_Handle = Selector.GetHandle("insertSegmentOfMovie:fromRange:scaledToRange:");

	private static readonly IntPtr selInsertEmptySegmentAt_Handle = Selector.GetHandle("insertEmptySegmentAt:");

	private static readonly IntPtr selDeleteSegment_Handle = Selector.GetHandle("deleteSegment:");

	private static readonly IntPtr selScaleSegmentNewDuration_Handle = Selector.GetHandle("scaleSegment:newDuration:");

	private static readonly IntPtr selAddImageForDurationWithAttributes_Handle = Selector.GetHandle("addImage:forDuration:withAttributes:");

	private static readonly IntPtr selInsertSegmentOfTrackTimeRangeAtTime_Handle = Selector.GetHandle("insertSegmentOfTrack:timeRange:atTime:");

	private static readonly IntPtr selInsertSegmentOfTrackFromRangeScaledToRange_Handle = Selector.GetHandle("insertSegmentOfTrack:fromRange:scaledToRange:");

	private static readonly IntPtr selRemoveTrack_Handle = Selector.GetHandle("removeTrack:");

	private static readonly IntPtr selGenerateApertureModeDimensionsHandle = Selector.GetHandle("generateApertureModeDimensions");

	private static readonly IntPtr selRemoveApertureModeDimensionsHandle = Selector.GetHandle("removeApertureModeDimensions");

	private static readonly IntPtr selEnterQTKitOnThreadHandle = Selector.GetHandle("enterQTKitOnThread");

	private static readonly IntPtr selEnterQTKitOnThreadDisablingThreadSafetyProtectionHandle = Selector.GetHandle("enterQTKitOnThreadDisablingThreadSafetyProtection");

	private static readonly IntPtr selExitQTKitOnThreadHandle = Selector.GetHandle("exitQTKitOnThread");

	private static readonly IntPtr selAttachToCurrentThreadHandle = Selector.GetHandle("attachToCurrentThread");

	private static readonly IntPtr selDetachFromCurrentThreadHandle = Selector.GetHandle("detachFromCurrentThread");

	private static readonly IntPtr selChaptersHandle = Selector.GetHandle("chapters");

	private static readonly IntPtr selRemoveChaptersHandle = Selector.GetHandle("removeChapters");

	private static readonly IntPtr selStartTimeOfChapter_Handle = Selector.GetHandle("startTimeOfChapter:");

	private static readonly IntPtr selChapterIndexForTime_Handle = Selector.GetHandle("chapterIndexForTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTMovie");

	private static object __mt_Movie_var_static;

	private object __mt_MovieAttributes_var;

	private object __mt_Tracks_var;

	private object __mt_PosterImage_var;

	private object __mt_CurrentFrameImage_var;

	private object __mt_WeakDelegate_var;

	private static NSString _PasteboardType;

	private static NSString _EditabilityDidChangeNotification;

	private static NSString _EditedNotification;

	private static NSString _LoadStateDidChangeNotification;

	private static NSString _LoopModeDidChangeNotification;

	private static NSString _MessageStringPostedNotification;

	private static NSString _RateDidChangeNotification;

	private static NSString _SelectionDidChangeNotification;

	private static NSString _SizeDidChangeNotification;

	private static NSString _StatusStringPostedNotification;

	private static NSString _TimeDidChangeNotification;

	private static NSString _VolumeDidChangeNotification;

	private static NSString _DidEndNotification;

	private static NSString _ChapterDidChangeNotification;

	private static NSString _ChapterListDidChangeNotification;

	private static NSString _EnterFullScreenRequestNotification;

	private static NSString _ExitFullScreenRequestNotification;

	private static NSString _CloseWindowRequestNotification;

	private static NSString _ApertureModeDidChangeNotification;

	private static NSString _MessageNotificationParameter;

	private static NSString _RateDidChangeNotificationParameter;

	private static NSString _StatusFlagsNotificationParameter;

	private static NSString _StatusCodeNotificationParameter;

	private static NSString _StatusStringNotificationParameter;

	private static NSString _TargetIDNotificationParameter;

	private static NSString _TargetNameNotificationParameter;

	private static NSString _KeyExport;

	private static NSString _KeyExportType;

	private static NSString _KeyFlatten;

	private static NSString _KeyExportSettings;

	private static NSString _KeyExportManufacturer;

	private static NSString _ImageCodecType;

	private static NSString _ImageCodecQuality;

	private static NSString _DataReferenceAttribute;

	private static NSString _PasteboardAttribute;

	private static NSString _DataAttribute;

	private static NSString _FileOffsetAttribute;

	private static NSString _ResolveDataRefsAttribute;

	private static NSString _AskUnresolvedDataRefsAttribute;

	private static NSString _OpenAsyncOKAttribute;

	private static NSString _ApertureModeAttribute;

	private static NSString _ActiveSegmentAttribute;

	private static NSString _AutoAlternatesAttribute;

	private static NSString _CopyrightAttribute;

	private static NSString _CreationTimeAttribute;

	private static NSString _CurrentSizeAttribute;

	private static NSString _CurrentTimeAttribute;

	private static NSString _DataSizeAttribute;

	private static NSString _DelegateAttribute;

	private static NSString _DisplayNameAttribute;

	private static NSString _DontInteractWithUserAttribute;

	private static NSString _DurationAttribute;

	private static NSString _EditableAttribute;

	private static NSString _FileNameAttribute;

	private static NSString _HasApertureModeDimensionsAttribute;

	private static NSString _HasAudioAttribute;

	private static NSString _HasDurationAttribute;

	private static NSString _HasVideoAttribute;

	private static NSString _IsActiveAttribute;

	private static NSString _IsInteractiveAttribute;

	private static NSString _IsLinearAttribute;

	private static NSString _IsSteppableAttribute;

	private static NSString _LoadStateAttribute;

	private static NSString _LoopsAttribute;

	private static NSString _LoopsBackAndForthAttribute;

	private static NSString _ModificationTimeAttribute;

	private static NSString _MutedAttribute;

	private static NSString _NaturalSizeAttribute;

	private static NSString _PlaysAllFramesAttribute;

	private static NSString _PlaysSelectionOnlyAttribute;

	private static NSString _PosterTimeAttribute;

	private static NSString _PreferredMutedAttribute;

	private static NSString _PreferredRateAttribute;

	private static NSString _PreferredVolumeAttribute;

	private static NSString _PreviewModeAttribute;

	private static NSString _PreviewRangeAttribute;

	private static NSString _RateAttribute;

	private static NSString _SelectionAttribute;

	private static NSString _TimeScaleAttribute;

	private static NSString _URLAttribute;

	private static NSString _VolumeAttribute;

	private static NSString _RateChangesPreservePitchAttribute;

	private static NSString _ApertureModeClassic;

	private static NSString _ApertureModeClean;

	private static NSString _ApertureModeProduction;

	private static NSString _ApertureModeEncodedPixels;

	private static NSString _FrameImageSize;

	private static NSString _FrameImageType;

	private static NSString _FrameImageTypeNSImage;

	private static NSString _FrameImageTypeCGImageRef;

	private static NSString _FrameImageTypeCIImage;

	private static NSString _FrameImageTypeCVPixelBufferRef;

	private static NSString _FrameImageTypeCVOpenGLTextureRef;

	private static NSString _FrameImageOpenGLContext;

	private static NSString _FrameImagePixelFormat;

	private static NSString _FrameImageRepresentationsType;

	private static NSString _FrameImageDeinterlaceFields;

	private static NSString _FrameImageHighQuality;

	private static NSString _FrameImageSingleField;

	private static NSString _UneditableException;

	private static NSString _ChapterName;

	private static NSString _ChapterStartTime;

	private static NSString _ChapterTargetTrackAttribute;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTTime Duration
	{
		[Export("duration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	public static QTMovie Movie
	{
		[Export("movie")]
		get
		{
			return (QTMovie)(__mt_Movie_var_static = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieHandle)));
		}
	}

	public virtual QTTime CurrentTime
	{
		[Export("currentTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Export("setCurrentTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_QTTime(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_QTTime(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	public virtual bool Muted
	{
		[Export("muted")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMutedHandle);
		}
		[Export("setMuted:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMuted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMuted_Handle, value);
			}
		}
	}

	public virtual NSDictionary MovieAttributes
	{
		[Export("movieAttributes")]
		get
		{
			return (NSDictionary)(__mt_MovieAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieAttributesHandle)))));
		}
		[Export("setMovieAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovieAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovieAttributes_Handle, value.Handle);
			}
			__mt_MovieAttributes_var = value;
		}
	}

	public virtual QTTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			return (QTTrack[])(__mt_Tracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle)) : NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle))));
		}
	}

	public virtual NSImage PosterImage
	{
		[Export("posterImage")]
		get
		{
			return (NSImage)(__mt_PosterImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPosterImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPosterImageHandle)))));
		}
	}

	public virtual NSImage CurrentFrameImage
	{
		[Export("currentFrameImage")]
		get
		{
			return (NSImage)(__mt_CurrentFrameImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentFrameImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentFrameImageHandle)))));
		}
	}

	public virtual bool CanUpdateMovieFile
	{
		[Export("canUpdateMovieFile")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanUpdateMovieFileHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanUpdateMovieFileHandle);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public virtual bool Idling
	{
		[Export("isIdling")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIdlingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIdlingHandle);
		}
	}

	public virtual bool HasChapters
	{
		[Export("hasChapters")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasChaptersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChaptersHandle);
		}
	}

	public virtual int ChapterCount
	{
		[Export("chapterCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selChapterCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selChapterCountHandle);
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

	[Field("QTMovieEditabilityDidChangeNotification", "QTKit")]
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

	[Field("QTMovieEditedNotification", "QTKit")]
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

	[Field("QTMovieLoadStateDidChangeNotification", "QTKit")]
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

	[Field("QTMovieMessageStringPostedNotification", "QTKit")]
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

	[Field("QTMovieRateDidChangeNotification", "QTKit")]
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

	[Field("QTMovieSelectionDidChangeNotification", "QTKit")]
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

	[Field("QTMovieStatusStringPostedNotification", "QTKit")]
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

	[Field("QTMovieTimeDidChangeNotification", "QTKit")]
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

	[Field("QTMovieVolumeDidChangeNotification", "QTKit")]
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

	[Field("QTMovieDidEndNotification", "QTKit")]
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

	[Field("QTMovieChapterDidChangeNotification", "QTKit")]
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

	[Field("QTMovieEnterFullScreenRequestNotification", "QTKit")]
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

	[Field("QTMovieCloseWindowRequestNotification", "QTKit")]
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

	[Field("QTMovieApertureModeDidChangeNotification", "QTKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovie()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTMovie(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTMovie(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTMovie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canInitWithPasteboard:")]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("canInitWithFile:")]
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

	[Export("canInitWithURL:")]
	public static bool CanInitWithUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithURL_Handle, url.Handle);
	}

	[Export("movieFileTypes:")]
	public static string[] MovieFileTypes(QTMovieFileTypeOptions types)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_int(class_ptr, selMovieFileTypes_Handle, (int)types));
	}

	[Export("movieUnfilteredFileTypes")]
	public static string[] MovieUnfilteredFileTypes()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieUnfilteredFileTypesHandle));
	}

	[Export("movieUnfilteredPasteboardTypes")]
	public static string[] MovieUnfilteredPasteboardTypes()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selMovieUnfilteredPasteboardTypesHandle));
	}

	[Export("movieTypesWithOptions:")]
	public static string[] MovieTypesWithOptions(QTMovieFileTypeOptions types)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_int(class_ptr, selMovieTypesWithOptions_Handle, (int)types));
	}

	[Export("movieWithFile:error:")]
	public static QTMovie FromFile(string fileName, out NSError error)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(fileName);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithFileError_Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieWithURL:error:")]
	public static QTMovie FromUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieWithPasteboard:error:")]
	public static QTMovie FromPasteboard(NSPasteboard pasteboard, out NSError error)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithPasteboardError_Handle, pasteboard.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieWithData:error:")]
	public static QTMovie FromData(NSData data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithDataError_Handle, data.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieWithAttributes:error:")]
	public static QTMovie FromAttributes(NSDictionary attributes, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieWithAttributesError_Handle, attributes.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieNamed:error:")]
	public static QTMovie FromMovieNamed(string name, out NSError error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(name);
		QTMovie result = (QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMovieNamedError_Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initWithFile:error:")]
	public QTMovie(string fileName, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(fileName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithFileError_Handle, arg, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithFileError_Handle, arg, intPtr);
		}
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithURL:error:")]
	public QTMovie(NSUrl url, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURLError_Handle, url.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURLError_Handle, url.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithDataReference:error:")]
	public QTMovie(QTDataReference dataReference, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (dataReference == null)
		{
			throw new ArgumentNullException("dataReference");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDataReferenceError_Handle, dataReference.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDataReferenceError_Handle, dataReference.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithPasteboard:error:")]
	public QTMovie(NSPasteboard pasteboard, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithPasteboardError_Handle, pasteboard.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithPasteboardError_Handle, pasteboard.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithData:error:")]
	public QTMovie(NSData data, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDataError_Handle, data.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDataError_Handle, data.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithMovie:timeRange:error:")]
	public QTMovie(QTMovie movie, QTTimeRange range, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_IntPtr(base.Handle, selInitWithMovieTimeRangeError_Handle, movie.Handle, range, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_IntPtr(base.SuperHandle, selInitWithMovieTimeRangeError_Handle, movie.Handle, range, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithAttributes:error:")]
	public QTMovie(NSDictionary attributes, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAttributesError_Handle, attributes.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAttributesError_Handle, attributes.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("movieWithTimeRange:error:")]
	public QTMovie(QTTimeRange range, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_QTTimeRange_IntPtr(base.Handle, selMovieWithTimeRangeError_Handle, range, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_QTTimeRange_IntPtr(base.SuperHandle, selMovieWithTimeRangeError_Handle, range, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initToWritableData:error:")]
	public QTMovie(NSMutableData data, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitToWritableDataError_Handle, data.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitToWritableDataError_Handle, data.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("invalidate")]
	public virtual void Invalidate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("attributeForKey:")]
	public virtual NSObject GetAttribute(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttribute:forKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributeForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributeForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("tracksOfMediaType:")]
	public virtual QTTrack[] TracksOfMediaType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		QTTrack[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksOfMediaType_Handle, arg)) : NSArray.ArrayFromHandle<QTTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksOfMediaType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("frameImageAtTime:")]
	public virtual NSImage FrameImageAtTime(QTTime time)
	{
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_QTTime(base.Handle, selFrameImageAtTime_Handle, time));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_QTTime(base.SuperHandle, selFrameImageAtTime_Handle, time));
	}

	[Export("frameImageAtTime:withAttributes:error:")]
	public virtual IntPtr FrameImageAtTime(QTTime time, NSDictionary attributes, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_QTTime_IntPtr_IntPtr(base.SuperHandle, selFrameImageAtTimeWithAttributesError_Handle, time, attributes.Handle, intPtr) : Messaging.IntPtr_objc_msgSend_QTTime_IntPtr_IntPtr(base.Handle, selFrameImageAtTimeWithAttributesError_Handle, time, attributes.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("movieFormatRepresentation")]
	public virtual NSData MovieFormatRepresentation()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieFormatRepresentationHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieFormatRepresentationHandle));
	}

	[Export("writeToFile:withAttributes:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToFileWithAttributes_Handle, arg, attributes.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToFileWithAttributes_Handle, arg, attributes.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToFile:withAttributes:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(fileName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteToFileWithAttributesError_Handle, arg, attributes.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selWriteToFileWithAttributesError_Handle, arg, attributes.Handle, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("updateMovieFile")]
	public virtual bool UpdateMovieFile()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUpdateMovieFileHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUpdateMovieFileHandle);
	}

	[Export("autoplay")]
	public virtual void Autoplay()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAutoplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAutoplayHandle);
		}
	}

	[Export("play")]
	public virtual void Play()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
		}
	}

	[Export("stop")]
	public virtual void Stop()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	[Export("gotoBeginning")]
	public virtual void GotoBeginning()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoBeginningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoBeginningHandle);
		}
	}

	[Export("gotoEnd")]
	public virtual void GotoEnd()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoEndHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoEndHandle);
		}
	}

	[Export("gotoNextSelectionPoint")]
	public virtual void GotoNextSelectionPoint()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoNextSelectionPointHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoNextSelectionPointHandle);
		}
	}

	[Export("gotoPreviousSelectionPoint")]
	public virtual void GotoPreviousSelectionPoint()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoPreviousSelectionPointHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoPreviousSelectionPointHandle);
		}
	}

	[Export("gotoPosterTime")]
	public virtual void GotoPosterTime()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGotoPosterTimeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGotoPosterTimeHandle);
		}
	}

	[Export("stepForward")]
	public virtual void StepForward()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStepForwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStepForwardHandle);
		}
	}

	[Export("stepBackward")]
	public virtual void StepBackward()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStepBackwardHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStepBackwardHandle);
		}
	}

	[Export("setSelection:")]
	public virtual void SetSelection(QTTimeRange selection)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selSetSelection_Handle, selection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selSetSelection_Handle, selection);
		}
	}

	[Export("selectionStart")]
	public virtual QTTime SelectionStart()
	{
		if (IsDirectBinding)
		{
			return Messaging.QTTime_objc_msgSend(base.Handle, selSelectionStartHandle);
		}
		return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selSelectionStartHandle);
	}

	[Export("selectionEnd")]
	public virtual QTTime SelectionEnd()
	{
		if (IsDirectBinding)
		{
			return Messaging.QTTime_objc_msgSend(base.Handle, selSelectionEndHandle);
		}
		return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selSelectionEndHandle);
	}

	[Export("selectionDuration")]
	public virtual QTTime SelectionDuration()
	{
		if (IsDirectBinding)
		{
			return Messaging.QTTime_objc_msgSend(base.Handle, selSelectionDurationHandle);
		}
		return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selSelectionDurationHandle);
	}

	[Export("replaceSelectionWithSelectionFromMovie:")]
	public virtual void ReplaceSelectionWithSelectionFromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceSelectionWithSelectionFromMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceSelectionWithSelectionFromMovie_Handle, movie.Handle);
		}
	}

	[Export("appendSelectionFromMovie:")]
	public virtual void AppendSelectionFromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendSelectionFromMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendSelectionFromMovie_Handle, movie.Handle);
		}
	}

	[Export("insertSegmentOfMovie:timeRange:atTime:")]
	public virtual void InsertSegmentOfMovieTimeRange(QTMovie movie, QTTimeRange range, QTTime time)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfMovieTimeRangeAtTime_Handle, movie.Handle, range, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfMovieTimeRangeAtTime_Handle, movie.Handle, range, time);
		}
	}

	[Export("insertSegmentOfMovie:fromRange:scaledToRange:")]
	public virtual void InsertSegmentOfMovieFromRange(QTMovie movie, QTTimeRange srcRange, QTTimeRange dstRange)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfMovieFromRangeScaledToRange_Handle, movie.Handle, srcRange, dstRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfMovieFromRangeScaledToRange_Handle, movie.Handle, srcRange, dstRange);
		}
	}

	[Export("insertEmptySegmentAt:")]
	public virtual void InsertEmptySegmentAt(QTTimeRange range)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selInsertEmptySegmentAt_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selInsertEmptySegmentAt_Handle, range);
		}
	}

	[Export("deleteSegment:")]
	public virtual void DeleteSegment(QTTimeRange segment)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange(base.Handle, selDeleteSegment_Handle, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange(base.SuperHandle, selDeleteSegment_Handle, segment);
		}
	}

	[Export("scaleSegment:newDuration:")]
	public virtual void ScaleSegmentNewDuration(QTTimeRange segment, QTTime newDuration)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_QTTimeRange_QTTime(base.Handle, selScaleSegmentNewDuration_Handle, segment, newDuration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_QTTimeRange_QTTime(base.SuperHandle, selScaleSegmentNewDuration_Handle, segment, newDuration);
		}
	}

	[Export("addImage:forDuration:withAttributes:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTime_IntPtr(base.Handle, selAddImageForDurationWithAttributes_Handle, image.Handle, duration, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTime_IntPtr(base.SuperHandle, selAddImageForDurationWithAttributes_Handle, image.Handle, duration, attributes.Handle);
		}
	}

	[Export("insertSegmentOfTrack:timeRange:atTime:")]
	public virtual QTTrack InsertSegmentOfTrackTimeRange(QTTrack track, QTTimeRange range, QTTime time)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			return (QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfTrackTimeRangeAtTime_Handle, track.Handle, range, time));
		}
		return (QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfTrackTimeRangeAtTime_Handle, track.Handle, range, time));
	}

	[Export("insertSegmentOfTrack:fromRange:scaledToRange:")]
	public virtual QTTrack InsertSegmentOfTrackFromRange(QTTrack track, QTTimeRange srcRange, QTTimeRange dstRange)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			return (QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfTrackFromRangeScaledToRange_Handle, track.Handle, srcRange, dstRange));
		}
		return (QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfTrackFromRangeScaledToRange_Handle, track.Handle, srcRange, dstRange));
	}

	[Export("removeTrack:")]
	public virtual void RemoveTrack(QTTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrack_Handle, track.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrack_Handle, track.Handle);
		}
	}

	[Export("generateApertureModeDimensions")]
	public virtual void GenerateApertureModeDimensions()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selGenerateApertureModeDimensionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selGenerateApertureModeDimensionsHandle);
		}
	}

	[Export("removeApertureModeDimensions")]
	public virtual void RemoveApertureModeDimensions()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveApertureModeDimensionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveApertureModeDimensionsHandle);
		}
	}

	[Export("enterQTKitOnThread")]
	public static void EnterQTKitOnThread()
	{
		Messaging.void_objc_msgSend(class_ptr, selEnterQTKitOnThreadHandle);
	}

	[Export("enterQTKitOnThreadDisablingThreadSafetyProtection")]
	public static void EnterQTKitOnThreadDisablingThreadSafetyProtection()
	{
		Messaging.void_objc_msgSend(class_ptr, selEnterQTKitOnThreadDisablingThreadSafetyProtectionHandle);
	}

	[Export("exitQTKitOnThread")]
	public static void ExitQTKitOnThread()
	{
		Messaging.void_objc_msgSend(class_ptr, selExitQTKitOnThreadHandle);
	}

	[Export("attachToCurrentThread")]
	public virtual bool AttachToCurrentThread()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAttachToCurrentThreadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAttachToCurrentThreadHandle);
	}

	[Export("detachFromCurrentThread")]
	public virtual bool DetachFromCurrentThread()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDetachFromCurrentThreadHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDetachFromCurrentThreadHandle);
	}

	[Export("chapters")]
	public virtual NSDictionary[] Chapters()
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selChaptersHandle));
		}
		return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChaptersHandle));
	}

	[Export("removeChapters")]
	public virtual bool RemoveChapters()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRemoveChaptersHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRemoveChaptersHandle);
	}

	[Export("startTimeOfChapter:")]
	public virtual QTTime StartTimeOfChapter(int chapterIndex)
	{
		if (IsDirectBinding)
		{
			return Messaging.QTTime_objc_msgSend_int(base.Handle, selStartTimeOfChapter_Handle, chapterIndex);
		}
		return Messaging.QTTime_objc_msgSendSuper_int(base.SuperHandle, selStartTimeOfChapter_Handle, chapterIndex);
	}

	[Export("chapterIndexForTime:")]
	public virtual int ChapterIndexForTime(QTTime time)
	{
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_QTTime(base.Handle, selChapterIndexForTime_Handle, time);
		}
		return Messaging.int_objc_msgSendSuper_QTTime(base.SuperHandle, selChapterIndexForTime_Handle, time);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MovieAttributes_var = null;
			__mt_Tracks_var = null;
			__mt_PosterImage_var = null;
			__mt_CurrentFrameImage_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
