using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTTrack", true)]
public class QTTrack : NSObject
{
	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	private static readonly IntPtr selMediaHandle = Selector.GetHandle("media");

	private static readonly IntPtr selQuickTimeTrackHandle = Selector.GetHandle("quickTimeTrack");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr selTrackAttributesHandle = Selector.GetHandle("trackAttributes");

	private static readonly IntPtr selSetTrackAttributes_Handle = Selector.GetHandle("setTrackAttributes:");

	private static readonly IntPtr selTrackWithQuickTimeTrackError_Handle = Selector.GetHandle("trackWithQuickTimeTrack:error:");

	private static readonly IntPtr selInitWithQuickTimeTrackError_Handle = Selector.GetHandle("initWithQuickTimeTrack:error:");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selSetAttributeForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	private static readonly IntPtr selInsertSegmentOfTrackTimeRangeAtTime_Handle = Selector.GetHandle("insertSegmentOfTrack:timeRange:atTime:");

	private static readonly IntPtr selInsertSegmentOfTrackFromRangeScaledToRange_Handle = Selector.GetHandle("insertSegmentOfTrack:fromRange:scaledToRange:");

	private static readonly IntPtr selInsertEmptySegmentAt_Handle = Selector.GetHandle("insertEmptySegmentAt:");

	private static readonly IntPtr selDeleteSegment_Handle = Selector.GetHandle("deleteSegment:");

	private static readonly IntPtr selScaleSegmentNewDuration_Handle = Selector.GetHandle("scaleSegment:newDuration:");

	private static readonly IntPtr selAddImageForDurationWithAttributes_Handle = Selector.GetHandle("addImage:forDuration:withAttributes:");

	private static readonly IntPtr selApertureModeDimensionsForMode_Handle = Selector.GetHandle("apertureModeDimensionsForMode:");

	private static readonly IntPtr selSetApertureModeDimensionsForMode_Handle = Selector.GetHandle("setApertureModeDimensions:forMode:");

	private static readonly IntPtr selGenerateApertureModeDimensionsHandle = Selector.GetHandle("generateApertureModeDimensions");

	private static readonly IntPtr selRemoveApertureModeDimensionsHandle = Selector.GetHandle("removeApertureModeDimensions");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTTrack");

	private object __mt_Movie_var;

	private object __mt_Media_var;

	private object __mt_TrackAttributes_var;

	private static NSString _BoundsAttribute;

	private static NSString _CreationTimeAttribute;

	private static NSString _DimensionsAttribute;

	private static NSString _DisplayNameAttribute;

	private static NSString _EnabledAttribute;

	private static NSString _FormatSummaryAttribute;

	private static NSString _IsChapterTrackAttribute;

	private static NSString _HasApertureModeDimensionsAttribute;

	private static NSString _IDAttribute;

	private static NSString _LayerAttribute;

	private static NSString _MediaTypeAttribute;

	private static NSString _ModificationTimeAttribute;

	private static NSString _RangeAttribute;

	private static NSString _TimeScaleAttribute;

	private static NSString _UsageInMovieAttribute;

	private static NSString _UsageInPosterAttribute;

	private static NSString _UsageInPreviewAttribute;

	private static NSString _VolumeAttribute;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			return (QTMovie)(__mt_Movie_var = ((!IsDirectBinding) ? ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle))) : ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle)))));
		}
	}

	public virtual QTMedia Media
	{
		[Export("media")]
		get
		{
			return (QTMedia)(__mt_Media_var = ((!IsDirectBinding) ? ((QTMedia)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaHandle))) : ((QTMedia)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaHandle)))));
		}
	}

	public virtual IntPtr QuickTimeTrack
	{
		[Export("quickTimeTrack")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeTrackHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeTrackHandle);
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
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

	public virtual NSDictionary TrackAttributes
	{
		[Export("trackAttributes")]
		get
		{
			return (NSDictionary)(__mt_TrackAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackAttributesHandle)))));
		}
		[Export("setTrackAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTrackAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTrackAttributes_Handle, value.Handle);
			}
			__mt_TrackAttributes_var = value;
		}
	}

	[Field("QTTrackBoundsAttribute", "QTKit")]
	public static NSString BoundsAttribute
	{
		get
		{
			if (_BoundsAttribute == null)
			{
				_BoundsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackBoundsAttribute");
			}
			return _BoundsAttribute;
		}
	}

	[Field("QTTrackCreationTimeAttribute", "QTKit")]
	public static NSString CreationTimeAttribute
	{
		get
		{
			if (_CreationTimeAttribute == null)
			{
				_CreationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackCreationTimeAttribute");
			}
			return _CreationTimeAttribute;
		}
	}

	[Field("QTTrackDimensionsAttribute", "QTKit")]
	public static NSString DimensionsAttribute
	{
		get
		{
			if (_DimensionsAttribute == null)
			{
				_DimensionsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackDimensionsAttribute");
			}
			return _DimensionsAttribute;
		}
	}

	[Field("QTTrackDisplayNameAttribute", "QTKit")]
	public static NSString DisplayNameAttribute
	{
		get
		{
			if (_DisplayNameAttribute == null)
			{
				_DisplayNameAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackDisplayNameAttribute");
			}
			return _DisplayNameAttribute;
		}
	}

	[Field("QTTrackEnabledAttribute", "QTKit")]
	public static NSString EnabledAttribute
	{
		get
		{
			if (_EnabledAttribute == null)
			{
				_EnabledAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackEnabledAttribute");
			}
			return _EnabledAttribute;
		}
	}

	[Field("QTTrackFormatSummaryAttribute", "QTKit")]
	public static NSString FormatSummaryAttribute
	{
		get
		{
			if (_FormatSummaryAttribute == null)
			{
				_FormatSummaryAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackFormatSummaryAttribute");
			}
			return _FormatSummaryAttribute;
		}
	}

	[Field("QTTrackIsChapterTrackAttribute", "QTKit")]
	public static NSString IsChapterTrackAttribute
	{
		get
		{
			if (_IsChapterTrackAttribute == null)
			{
				_IsChapterTrackAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackIsChapterTrackAttribute");
			}
			return _IsChapterTrackAttribute;
		}
	}

	[Field("QTTrackHasApertureModeDimensionsAttribute", "QTKit")]
	public static NSString HasApertureModeDimensionsAttribute
	{
		get
		{
			if (_HasApertureModeDimensionsAttribute == null)
			{
				_HasApertureModeDimensionsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackHasApertureModeDimensionsAttribute");
			}
			return _HasApertureModeDimensionsAttribute;
		}
	}

	[Field("QTTrackIDAttribute", "QTKit")]
	public static NSString IDAttribute
	{
		get
		{
			if (_IDAttribute == null)
			{
				_IDAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackIDAttribute");
			}
			return _IDAttribute;
		}
	}

	[Field("QTTrackLayerAttribute", "QTKit")]
	public static NSString LayerAttribute
	{
		get
		{
			if (_LayerAttribute == null)
			{
				_LayerAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackLayerAttribute");
			}
			return _LayerAttribute;
		}
	}

	[Field("QTTrackMediaTypeAttribute", "QTKit")]
	public static NSString MediaTypeAttribute
	{
		get
		{
			if (_MediaTypeAttribute == null)
			{
				_MediaTypeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackMediaTypeAttribute");
			}
			return _MediaTypeAttribute;
		}
	}

	[Field("QTTrackModificationTimeAttribute", "QTKit")]
	public static NSString ModificationTimeAttribute
	{
		get
		{
			if (_ModificationTimeAttribute == null)
			{
				_ModificationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackModificationTimeAttribute");
			}
			return _ModificationTimeAttribute;
		}
	}

	[Field("QTTrackRangeAttribute", "QTKit")]
	public static NSString RangeAttribute
	{
		get
		{
			if (_RangeAttribute == null)
			{
				_RangeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackRangeAttribute");
			}
			return _RangeAttribute;
		}
	}

	[Field("QTTrackTimeScaleAttribute", "QTKit")]
	public static NSString TimeScaleAttribute
	{
		get
		{
			if (_TimeScaleAttribute == null)
			{
				_TimeScaleAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackTimeScaleAttribute");
			}
			return _TimeScaleAttribute;
		}
	}

	[Field("QTTrackUsageInMovieAttribute", "QTKit")]
	public static NSString UsageInMovieAttribute
	{
		get
		{
			if (_UsageInMovieAttribute == null)
			{
				_UsageInMovieAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackUsageInMovieAttribute");
			}
			return _UsageInMovieAttribute;
		}
	}

	[Field("QTTrackUsageInPosterAttribute", "QTKit")]
	public static NSString UsageInPosterAttribute
	{
		get
		{
			if (_UsageInPosterAttribute == null)
			{
				_UsageInPosterAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackUsageInPosterAttribute");
			}
			return _UsageInPosterAttribute;
		}
	}

	[Field("QTTrackUsageInPreviewAttribute", "QTKit")]
	public static NSString UsageInPreviewAttribute
	{
		get
		{
			if (_UsageInPreviewAttribute == null)
			{
				_UsageInPreviewAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackUsageInPreviewAttribute");
			}
			return _UsageInPreviewAttribute;
		}
	}

	[Field("QTTrackVolumeAttribute", "QTKit")]
	public static NSString VolumeAttribute
	{
		get
		{
			if (_VolumeAttribute == null)
			{
				_VolumeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTTrackVolumeAttribute");
			}
			return _VolumeAttribute;
		}
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
	public QTTrack()
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
	public QTTrack(NSCoder coder)
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
	public QTTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("trackWithQuickTimeTrack:error:")]
	public static NSObject FromQuickTimeTrack(IntPtr quicktimeTrack, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTrackWithQuickTimeTrackError_Handle, quicktimeTrack, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	[Export("initWithQuickTimeTrack:error:")]
	public QTTrack(IntPtr quicktimeTrack, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithQuickTimeTrackError_Handle, quicktimeTrack, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithQuickTimeTrackError_Handle, quicktimeTrack, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
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

	[Export("insertSegmentOfTrack:timeRange:atTime:")]
	public virtual void InsertSegmentOfTrack(QTTrack track, QTTimeRange timeRange, QTTime atTime)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfTrackTimeRangeAtTime_Handle, track.Handle, timeRange, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfTrackTimeRangeAtTime_Handle, track.Handle, timeRange, atTime);
		}
	}

	[Export("insertSegmentOfTrack:fromRange:scaledToRange:")]
	public virtual void InsertSegmentOfTrack(QTTrack track, QTTimeRange fromRange, QTTimeRange scaledToRange)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfTrackFromRangeScaledToRange_Handle, track.Handle, fromRange, scaledToRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfTrackFromRangeScaledToRange_Handle, track.Handle, fromRange, scaledToRange);
		}
	}

	[Export("insertEmptySegmentAt:")]
	public virtual void InsertEmptySegment(QTTimeRange range)
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
	public virtual void ScaleSegmentnewDuration(QTTimeRange segment, QTTime newDuration)
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
	public virtual void AddImage(NSImage image, QTTime forDuration, NSDictionary attributes)
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
			Messaging.void_objc_msgSend_IntPtr_QTTime_IntPtr(base.Handle, selAddImageForDurationWithAttributes_Handle, image.Handle, forDuration, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTime_IntPtr(base.SuperHandle, selAddImageForDurationWithAttributes_Handle, image.Handle, forDuration, attributes.Handle);
		}
	}

	[Export("apertureModeDimensionsForMode:")]
	public virtual CGSize ApertureModeDimensionsForMode(string mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		CGSize result = ((!IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selApertureModeDimensionsForMode_Handle, arg) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selApertureModeDimensionsForMode_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setApertureModeDimensions:forMode:")]
	public virtual void SetApertureModeDimensionsforMode(CGSize dimensions, string mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize_IntPtr(base.Handle, selSetApertureModeDimensionsForMode_Handle, dimensions, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selSetApertureModeDimensionsForMode_Handle, dimensions, arg);
		}
		NSString.ReleaseNative(arg);
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Movie_var = null;
			__mt_Media_var = null;
			__mt_TrackAttributes_var = null;
		}
	}
}
