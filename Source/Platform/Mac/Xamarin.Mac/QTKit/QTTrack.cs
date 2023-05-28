using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTTrack", true)]
public class QTTrack : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddImage_ForDuration_WithAttributes_ = "addImage:forDuration:withAttributes:";

	private static readonly IntPtr selAddImage_ForDuration_WithAttributes_Handle = Selector.GetHandle("addImage:forDuration:withAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApertureModeDimensionsForMode_ = "apertureModeDimensionsForMode:";

	private static readonly IntPtr selApertureModeDimensionsForMode_Handle = Selector.GetHandle("apertureModeDimensionsForMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSegment_ = "deleteSegment:";

	private static readonly IntPtr selDeleteSegment_Handle = Selector.GetHandle("deleteSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateApertureModeDimensions = "generateApertureModeDimensions";

	private static readonly IntPtr selGenerateApertureModeDimensionsHandle = Selector.GetHandle("generateApertureModeDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithQuickTimeTrack_Error_ = "initWithQuickTimeTrack:error:";

	private static readonly IntPtr selInitWithQuickTimeTrack_Error_Handle = Selector.GetHandle("initWithQuickTimeTrack:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEmptySegmentAt_ = "insertEmptySegmentAt:";

	private static readonly IntPtr selInsertEmptySegmentAt_Handle = Selector.GetHandle("insertEmptySegmentAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfTrack_FromRange_ScaledToRange_ = "insertSegmentOfTrack:fromRange:scaledToRange:";

	private static readonly IntPtr selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle = Selector.GetHandle("insertSegmentOfTrack:fromRange:scaledToRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSegmentOfTrack_TimeRange_AtTime_ = "insertSegmentOfTrack:timeRange:atTime:";

	private static readonly IntPtr selInsertSegmentOfTrack_TimeRange_AtTime_Handle = Selector.GetHandle("insertSegmentOfTrack:timeRange:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMedia = "media";

	private static readonly IntPtr selMediaHandle = Selector.GetHandle("media");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovie = "movie";

	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickTimeTrack = "quickTimeTrack";

	private static readonly IntPtr selQuickTimeTrackHandle = Selector.GetHandle("quickTimeTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveApertureModeDimensions = "removeApertureModeDimensions";

	private static readonly IntPtr selRemoveApertureModeDimensionsHandle = Selector.GetHandle("removeApertureModeDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleSegment_NewDuration_ = "scaleSegment:newDuration:";

	private static readonly IntPtr selScaleSegment_NewDuration_Handle = Selector.GetHandle("scaleSegment:newDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApertureModeDimensions_ForMode_ = "setApertureModeDimensions:forMode:";

	private static readonly IntPtr selSetApertureModeDimensions_ForMode_Handle = Selector.GetHandle("setApertureModeDimensions:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackAttributes_ = "setTrackAttributes:";

	private static readonly IntPtr selSetTrackAttributes_Handle = Selector.GetHandle("setTrackAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackAttributes = "trackAttributes";

	private static readonly IntPtr selTrackAttributesHandle = Selector.GetHandle("trackAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackWithQuickTimeTrack_Error_ = "trackWithQuickTimeTrack:error:";

	private static readonly IntPtr selTrackWithQuickTimeTrack_Error_Handle = Selector.GetHandle("trackWithQuickTimeTrack:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoundsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DimensionsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayNameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnabledAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatSummaryAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasApertureModeDimensionsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IDAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsChapterTrackAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayerAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaTypeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModificationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeScaleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsageInMovieAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsageInPosterAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsageInPreviewAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeAttribute;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTMedia Media
	{
		[Export("media")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTMedia>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaHandle));
			}
			return Runtime.GetNSObject<QTMedia>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle));
			}
			return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual IntPtr QuickTimeTrack
	{
		[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("quickTimeTrack")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeTrackHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeTrackHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary TrackAttributes
	{
		[Export("trackAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackAttributesHandle));
		}
		[Export("setTrackAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTrackAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTrackAttributes_Handle, value.Handle);
			}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTTrack()
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
	protected QTTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithQuickTimeTrack:error:")]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTTrack(IntPtr quicktimeTrack, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithQuickTimeTrack_Error_Handle, quicktimeTrack, ref arg), "initWithQuickTimeTrack:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithQuickTimeTrack_Error_Handle, quicktimeTrack, ref arg), "initWithQuickTimeTrack:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addImage:forDuration:withAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTime_IntPtr(base.Handle, selAddImage_ForDuration_WithAttributes_Handle, image.Handle, forDuration, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTime_IntPtr(base.SuperHandle, selAddImage_ForDuration_WithAttributes_Handle, image.Handle, forDuration, attributes.Handle);
		}
	}

	[Export("apertureModeDimensionsForMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ApertureModeDimensionsForMode(string mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		CGSize result = ((!base.IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selApertureModeDimensionsForMode_Handle, arg) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selApertureModeDimensionsForMode_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("trackWithQuickTimeTrack:error:")]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject FromQuickTimeTrack(IntPtr quicktimeTrack, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selTrackWithQuickTimeTrack_Error_Handle, quicktimeTrack, ref arg));
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

	[Export("insertEmptySegmentAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertEmptySegment(QTTimeRange range)
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

	[Export("insertSegmentOfTrack:timeRange:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentOfTrack(QTTrack track, QTTimeRange timeRange, QTTime atTime)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTime(base.Handle, selInsertSegmentOfTrack_TimeRange_AtTime_Handle, track.Handle, timeRange, atTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(base.SuperHandle, selInsertSegmentOfTrack_TimeRange_AtTime_Handle, track.Handle, timeRange, atTime);
		}
	}

	[Export("insertSegmentOfTrack:fromRange:scaledToRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentOfTrack(QTTrack track, QTTimeRange fromRange, QTTimeRange scaledToRange)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(base.Handle, selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle, track.Handle, fromRange, scaledToRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(base.SuperHandle, selInsertSegmentOfTrack_FromRange_ScaledToRange_Handle, track.Handle, fromRange, scaledToRange);
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

	[Export("scaleSegment:newDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleSegmentnewDuration(QTTimeRange segment, QTTime newDuration)
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

	[Export("setApertureModeDimensions:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetApertureModeDimensionsforMode(CGSize dimensions, string mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize_IntPtr(base.Handle, selSetApertureModeDimensions_ForMode_Handle, dimensions, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selSetApertureModeDimensions_ForMode_Handle, dimensions, arg);
		}
		NSString.ReleaseNative(arg);
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
}
