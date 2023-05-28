using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableMovieTrack", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVMutableMovieTrack : AVMovieTrack
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateGroupID = "alternateGroupID";

	private static readonly IntPtr selAlternateGroupIDHandle = Selector.GetHandle("alternateGroupID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendSampleBuffer_DecodeTime_PresentationTime_Error_ = "appendSampleBuffer:decodeTime:presentationTime:error:";

	private static readonly IntPtr selAppendSampleBuffer_DecodeTime_PresentationTime_Error_Handle = Selector.GetHandle("appendSampleBuffer:decodeTime:presentationTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCleanApertureDimensions = "cleanApertureDimensions";

	private static readonly IntPtr selCleanApertureDimensionsHandle = Selector.GetHandle("cleanApertureDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodedPixelsDimensions = "encodedPixelsDimensions";

	private static readonly IntPtr selEncodedPixelsDimensionsHandle = Selector.GetHandle("encodedPixelsDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasProtectedContent = "hasProtectedContent";

	private static readonly IntPtr selHasProtectedContentHandle = Selector.GetHandle("hasProtectedContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertMediaTimeRange_IntoTimeRange_ = "insertMediaTimeRange:intoTimeRange:";

	private static readonly IntPtr selInsertMediaTimeRange_IntoTimeRange_Handle = Selector.GetHandle("insertMediaTimeRange:intoTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsModified = "isModified";

	private static readonly IntPtr selIsModifiedHandle = Selector.GetHandle("isModified");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageCode = "languageCode";

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaDataStorage = "mediaDataStorage";

	private static readonly IntPtr selMediaDataStorageHandle = Selector.GetHandle("mediaDataStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalSize = "naturalSize";

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaChunkAlignment = "preferredMediaChunkAlignment";

	private static readonly IntPtr selPreferredMediaChunkAlignmentHandle = Selector.GetHandle("preferredMediaChunkAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaChunkDuration = "preferredMediaChunkDuration";

	private static readonly IntPtr selPreferredMediaChunkDurationHandle = Selector.GetHandle("preferredMediaChunkDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaChunkSize = "preferredMediaChunkSize";

	private static readonly IntPtr selPreferredMediaChunkSizeHandle = Selector.GetHandle("preferredMediaChunkSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTransform = "preferredTransform";

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProductionApertureDimensions = "productionApertureDimensions";

	private static readonly IntPtr selProductionApertureDimensionsHandle = Selector.GetHandle("productionApertureDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceFormatDescription_WithFormatDescription_ = "replaceFormatDescription:withFormatDescription:";

	private static readonly IntPtr selReplaceFormatDescription_WithFormatDescription_Handle = Selector.GetHandle("replaceFormatDescription:withFormatDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleReferenceBaseURL = "sampleReferenceBaseURL";

	private static readonly IntPtr selSampleReferenceBaseURLHandle = Selector.GetHandle("sampleReferenceBaseURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateGroupID_ = "setAlternateGroupID:";

	private static readonly IntPtr selSetAlternateGroupID_Handle = Selector.GetHandle("setAlternateGroupID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCleanApertureDimensions_ = "setCleanApertureDimensions:";

	private static readonly IntPtr selSetCleanApertureDimensions_Handle = Selector.GetHandle("setCleanApertureDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEncodedPixelsDimensions_ = "setEncodedPixelsDimensions:";

	private static readonly IntPtr selSetEncodedPixelsDimensions_Handle = Selector.GetHandle("setEncodedPixelsDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtendedLanguageTag_ = "setExtendedLanguageTag:";

	private static readonly IntPtr selSetExtendedLanguageTag_Handle = Selector.GetHandle("setExtendedLanguageTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageCode_ = "setLanguageCode:";

	private static readonly IntPtr selSetLanguageCode_Handle = Selector.GetHandle("setLanguageCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayer_ = "setLayer:";

	private static readonly IntPtr selSetLayer_Handle = Selector.GetHandle("setLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaDataStorage_ = "setMediaDataStorage:";

	private static readonly IntPtr selSetMediaDataStorage_Handle = Selector.GetHandle("setMediaDataStorage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModified_ = "setModified:";

	private static readonly IntPtr selSetModified_Handle = Selector.GetHandle("setModified:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNaturalSize_ = "setNaturalSize:";

	private static readonly IntPtr selSetNaturalSize_Handle = Selector.GetHandle("setNaturalSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMediaChunkAlignment_ = "setPreferredMediaChunkAlignment:";

	private static readonly IntPtr selSetPreferredMediaChunkAlignment_Handle = Selector.GetHandle("setPreferredMediaChunkAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMediaChunkDuration_ = "setPreferredMediaChunkDuration:";

	private static readonly IntPtr selSetPreferredMediaChunkDuration_Handle = Selector.GetHandle("setPreferredMediaChunkDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMediaChunkSize_ = "setPreferredMediaChunkSize:";

	private static readonly IntPtr selSetPreferredMediaChunkSize_Handle = Selector.GetHandle("setPreferredMediaChunkSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredTransform_ = "setPreferredTransform:";

	private static readonly IntPtr selSetPreferredTransform_Handle = Selector.GetHandle("setPreferredTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredVolume_ = "setPreferredVolume:";

	private static readonly IntPtr selSetPreferredVolume_Handle = Selector.GetHandle("setPreferredVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProductionApertureDimensions_ = "setProductionApertureDimensions:";

	private static readonly IntPtr selSetProductionApertureDimensions_Handle = Selector.GetHandle("setProductionApertureDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleReferenceBaseURL_ = "setSampleReferenceBaseURL:";

	private static readonly IntPtr selSetSampleReferenceBaseURL_Handle = Selector.GetHandle("setSampleReferenceBaseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimescale_ = "setTimescale:";

	private static readonly IntPtr selSetTimescale_Handle = Selector.GetHandle("setTimescale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimescale = "timescale";

	private static readonly IntPtr selTimescaleHandle = Selector.GetHandle("timescale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableMovieTrack");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint AlternateGroupID
	{
		[Export("alternateGroupID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAlternateGroupIDHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAlternateGroupIDHandle);
		}
		[Export("setAlternateGroupID:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAlternateGroupID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAlternateGroupID_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize CleanApertureDimensions
	{
		[Export("cleanApertureDimensions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCleanApertureDimensionsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCleanApertureDimensionsHandle);
		}
		[Export("setCleanApertureDimensions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetCleanApertureDimensions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetCleanApertureDimensions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Enabled
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
	public virtual CGSize EncodedPixelsDimensions
	{
		[Export("encodedPixelsDimensions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selEncodedPixelsDimensionsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selEncodedPixelsDimensionsHandle);
		}
		[Export("setEncodedPixelsDimensions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetEncodedPixelsDimensions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetEncodedPixelsDimensions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? ExtendedLanguageTag
	{
		[Export("extendedLanguageTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
		[Export("setExtendedLanguageTag:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExtendedLanguageTag_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExtendedLanguageTag_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasProtectedContent
	{
		[Export("hasProtectedContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasProtectedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasProtectedContentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? LanguageCode
	{
		[Export("languageCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageCodeHandle));
		}
		[Export("setLanguageCode:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLanguageCode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguageCode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Layer
	{
		[Export("layer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLayerHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLayerHandle);
		}
		[Export("setLayer:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetLayer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetLayer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMediaDataStorage? MediaDataStorage
	{
		[Export("mediaDataStorage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaDataStorageHandle));
			}
			return Runtime.GetNSObject<AVMediaDataStorage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaDataStorageHandle));
		}
		[Export("setMediaDataStorage:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaDataStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaDataStorage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMetadataItem[] Metadata
	{
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Modified
	{
		[Export("isModified")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsModifiedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsModifiedHandle);
		}
		[Export("setModified:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetModified_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetModified_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGSize NaturalSize
	{
		[Export("naturalSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
		[Export("setNaturalSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetNaturalSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetNaturalSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PreferredMediaChunkAlignment
	{
		[Export("preferredMediaChunkAlignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredMediaChunkAlignmentHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredMediaChunkAlignmentHandle);
		}
		[Export("setPreferredMediaChunkAlignment:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPreferredMediaChunkAlignment_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPreferredMediaChunkAlignment_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime PreferredMediaChunkDuration
	{
		[Export("preferredMediaChunkDuration", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selPreferredMediaChunkDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredMediaChunkDurationHandle);
			}
			return retval;
		}
		[Export("setPreferredMediaChunkDuration:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetPreferredMediaChunkDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetPreferredMediaChunkDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PreferredMediaChunkSize
	{
		[Export("preferredMediaChunkSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredMediaChunkSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredMediaChunkSizeHandle);
		}
		[Export("setPreferredMediaChunkSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPreferredMediaChunkSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPreferredMediaChunkSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform", ArgumentSemantic.Assign)]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selPreferredTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredTransformHandle);
			}
			return retval;
		}
		[Export("setPreferredTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetPreferredTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetPreferredTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
		[Export("setPreferredVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreferredVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreferredVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ProductionApertureDimensions
	{
		[Export("productionApertureDimensions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selProductionApertureDimensionsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selProductionApertureDimensionsHandle);
		}
		[Export("setProductionApertureDimensions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetProductionApertureDimensions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetProductionApertureDimensions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? SampleReferenceBaseURL
	{
		[Export("sampleReferenceBaseURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleReferenceBaseURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleReferenceBaseURLHandle));
		}
		[Export("setSampleReferenceBaseURL:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSampleReferenceBaseURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSampleReferenceBaseURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Timescale
	{
		[Export("timescale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTimescaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTimescaleHandle);
		}
		[Export("setTimescale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTimescale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTimescale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableMovieTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableMovieTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendSampleBuffer:decodeTime:presentationTime:error:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppendSampleBuffer(CMSampleBuffer sampleBuffer, out CMTime outDecodeTime, out CMTime presentationTime, out NSError error)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_out_CMTime_out_CMTime_ref_IntPtr(base.SuperHandle, selAppendSampleBuffer_DecodeTime_PresentationTime_Error_Handle, sampleBuffer.Handle, out outDecodeTime, out presentationTime, ref arg) : Messaging.bool_objc_msgSend_IntPtr_out_CMTime_out_CMTime_ref_IntPtr(base.Handle, selAppendSampleBuffer_DecodeTime_PresentationTime_Error_Handle, sampleBuffer.Handle, out outDecodeTime, out presentationTime, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("insertMediaTimeRange:intoTimeRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InsertMediaTimeRange(CMTimeRange mediaTimeRange, CMTimeRange trackTimeRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTimeRange_CMTimeRange(base.Handle, selInsertMediaTimeRange_IntoTimeRange_Handle, mediaTimeRange, trackTimeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTimeRange_CMTimeRange(base.SuperHandle, selInsertMediaTimeRange_IntoTimeRange_Handle, mediaTimeRange, trackTimeRange);
	}

	[Export("replaceFormatDescription:withFormatDescription:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceFormatDescription(CMFormatDescription formatDescription, CMFormatDescription newFormatDescription)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (newFormatDescription == null)
		{
			throw new ArgumentNullException("newFormatDescription");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceFormatDescription_WithFormatDescription_Handle, formatDescription.Handle, newFormatDescription.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceFormatDescription_WithFormatDescription_Handle, formatDescription.Handle, newFormatDescription.Handle);
		}
	}
}
