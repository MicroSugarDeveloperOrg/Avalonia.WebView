using System;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetWriterInput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTrackAssociationWithTrackOfInput_Type_ = "addTrackAssociationWithTrackOfInput:type:";

	private static readonly IntPtr selAddTrackAssociationWithTrackOfInput_Type_Handle = Selector.GetHandle("addTrackAssociationWithTrackOfInput:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendSampleBuffer_ = "appendSampleBuffer:";

	private static readonly IntPtr selAppendSampleBuffer_Handle = Selector.GetHandle("appendSampleBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInputWithMediaType_OutputSettings_ = "assetWriterInputWithMediaType:outputSettings:";

	private static readonly IntPtr selAssetWriterInputWithMediaType_OutputSettings_Handle = Selector.GetHandle("assetWriterInputWithMediaType:outputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_ = "assetWriterInputWithMediaType:outputSettings:sourceFormatHint:";

	private static readonly IntPtr selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_Handle = Selector.GetHandle("assetWriterInputWithMediaType:outputSettings:sourceFormatHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddTrackAssociationWithTrackOfInput_Type_ = "canAddTrackAssociationWithTrackOfInput:type:";

	private static readonly IntPtr selCanAddTrackAssociationWithTrackOfInput_Type_Handle = Selector.GetHandle("canAddTrackAssociationWithTrackOfInput:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformMultiplePasses = "canPerformMultiplePasses";

	private static readonly IntPtr selCanPerformMultiplePassesHandle = Selector.GetHandle("canPerformMultiplePasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPassDescription = "currentPassDescription";

	private static readonly IntPtr selCurrentPassDescriptionHandle = Selector.GetHandle("currentPassDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpectsMediaDataInRealTime = "expectsMediaDataInRealTime";

	private static readonly IntPtr selExpectsMediaDataInRealTimeHandle = Selector.GetHandle("expectsMediaDataInRealTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMediaType_OutputSettings_ = "initWithMediaType:outputSettings:";

	private static readonly IntPtr selInitWithMediaType_OutputSettings_Handle = Selector.GetHandle("initWithMediaType:outputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMediaType_OutputSettings_SourceFormatHint_ = "initWithMediaType:outputSettings:sourceFormatHint:";

	private static readonly IntPtr selInitWithMediaType_OutputSettings_SourceFormatHint_Handle = Selector.GetHandle("initWithMediaType:outputSettings:sourceFormatHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadyForMoreMediaData = "isReadyForMoreMediaData";

	private static readonly IntPtr selIsReadyForMoreMediaDataHandle = Selector.GetHandle("isReadyForMoreMediaData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageCode = "languageCode";

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkAsFinished = "markAsFinished";

	private static readonly IntPtr selMarkAsFinishedHandle = Selector.GetHandle("markAsFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkCurrentPassAsFinished = "markCurrentPassAsFinished";

	private static readonly IntPtr selMarkCurrentPassAsFinishedHandle = Selector.GetHandle("markCurrentPassAsFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarksOutputTrackAsEnabled = "marksOutputTrackAsEnabled";

	private static readonly IntPtr selMarksOutputTrackAsEnabledHandle = Selector.GetHandle("marksOutputTrackAsEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaDataLocation = "mediaDataLocation";

	private static readonly IntPtr selMediaDataLocationHandle = Selector.GetHandle("mediaDataLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaTimeScale = "mediaTimeScale";

	private static readonly IntPtr selMediaTimeScaleHandle = Selector.GetHandle("mediaTimeScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalSize = "naturalSize";

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputSettings = "outputSettings";

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformsMultiPassEncodingIfSupported = "performsMultiPassEncodingIfSupported";

	private static readonly IntPtr selPerformsMultiPassEncodingIfSupportedHandle = Selector.GetHandle("performsMultiPassEncodingIfSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaChunkAlignment = "preferredMediaChunkAlignment";

	private static readonly IntPtr selPreferredMediaChunkAlignmentHandle = Selector.GetHandle("preferredMediaChunkAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaChunkDuration = "preferredMediaChunkDuration";

	private static readonly IntPtr selPreferredMediaChunkDurationHandle = Selector.GetHandle("preferredMediaChunkDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestMediaDataWhenReadyOnQueue_UsingBlock_ = "requestMediaDataWhenReadyOnQueue:usingBlock:";

	private static readonly IntPtr selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle = Selector.GetHandle("requestMediaDataWhenReadyOnQueue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRespondToEachPassDescriptionOnQueue_UsingBlock_ = "respondToEachPassDescriptionOnQueue:usingBlock:";

	private static readonly IntPtr selRespondToEachPassDescriptionOnQueue_UsingBlock_Handle = Selector.GetHandle("respondToEachPassDescriptionOnQueue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleReferenceBaseURL = "sampleReferenceBaseURL";

	private static readonly IntPtr selSampleReferenceBaseURLHandle = Selector.GetHandle("sampleReferenceBaseURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExpectsMediaDataInRealTime_ = "setExpectsMediaDataInRealTime:";

	private static readonly IntPtr selSetExpectsMediaDataInRealTime_Handle = Selector.GetHandle("setExpectsMediaDataInRealTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtendedLanguageTag_ = "setExtendedLanguageTag:";

	private static readonly IntPtr selSetExtendedLanguageTag_Handle = Selector.GetHandle("setExtendedLanguageTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageCode_ = "setLanguageCode:";

	private static readonly IntPtr selSetLanguageCode_Handle = Selector.GetHandle("setLanguageCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarksOutputTrackAsEnabled_ = "setMarksOutputTrackAsEnabled:";

	private static readonly IntPtr selSetMarksOutputTrackAsEnabled_Handle = Selector.GetHandle("setMarksOutputTrackAsEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaDataLocation_ = "setMediaDataLocation:";

	private static readonly IntPtr selSetMediaDataLocation_Handle = Selector.GetHandle("setMediaDataLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaTimeScale_ = "setMediaTimeScale:";

	private static readonly IntPtr selSetMediaTimeScale_Handle = Selector.GetHandle("setMediaTimeScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNaturalSize_ = "setNaturalSize:";

	private static readonly IntPtr selSetNaturalSize_Handle = Selector.GetHandle("setNaturalSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerformsMultiPassEncodingIfSupported_ = "setPerformsMultiPassEncodingIfSupported:";

	private static readonly IntPtr selSetPerformsMultiPassEncodingIfSupported_Handle = Selector.GetHandle("setPerformsMultiPassEncodingIfSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMediaChunkAlignment_ = "setPreferredMediaChunkAlignment:";

	private static readonly IntPtr selSetPreferredMediaChunkAlignment_Handle = Selector.GetHandle("setPreferredMediaChunkAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMediaChunkDuration_ = "setPreferredMediaChunkDuration:";

	private static readonly IntPtr selSetPreferredMediaChunkDuration_Handle = Selector.GetHandle("setPreferredMediaChunkDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredVolume_ = "setPreferredVolume:";

	private static readonly IntPtr selSetPreferredVolume_Handle = Selector.GetHandle("setPreferredVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleReferenceBaseURL_ = "setSampleReferenceBaseURL:";

	private static readonly IntPtr selSetSampleReferenceBaseURL_Handle = Selector.GetHandle("setSampleReferenceBaseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransform_ = "setTransform:";

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFormatHint = "sourceFormatHint";

	private static readonly IntPtr selSourceFormatHintHandle = Selector.GetHandle("sourceFormatHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetWriterInput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool CanPerformMultiplePasses
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("canPerformMultiplePasses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPerformMultiplePassesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPerformMultiplePassesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual AVAssetWriterInputPassDescription? CurrentPassDescription
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("currentPassDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetWriterInputPassDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPassDescriptionHandle));
			}
			return Runtime.GetNSObject<AVAssetWriterInputPassDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPassDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExpectsMediaDataInRealTime
	{
		[Export("expectsMediaDataInRealTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selExpectsMediaDataInRealTimeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selExpectsMediaDataInRealTimeHandle);
		}
		[Export("setExpectsMediaDataInRealTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExpectsMediaDataInRealTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExpectsMediaDataInRealTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string? ExtendedLanguageTag
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("extendedLanguageTag", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setExtendedLanguageTag:", ArgumentSemantic.Copy)]
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string? LanguageCode
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("languageCode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageCodeHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setLanguageCode:", ArgumentSemantic.Copy)]
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool MarksOutputTrackAsEnabled
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("marksOutputTrackAsEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMarksOutputTrackAsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMarksOutputTrackAsEnabledHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setMarksOutputTrackAsEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMarksOutputTrackAsEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMarksOutputTrackAsEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string MediaDataLocation
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("mediaDataLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaDataLocationHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaDataLocationHandle));
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setMediaDataLocation:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaDataLocation_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaDataLocation_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MediaTimeScale
	{
		[Export("mediaTimeScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMediaTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMediaTimeScaleHandle);
		}
		[Export("setMediaTimeScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMediaTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMediaTimeScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] Metadata
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGSize NaturalSize
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("naturalSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setNaturalSize:")]
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
	public virtual NSDictionary? OutputSettings
	{
		[Export("outputSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool PerformsMultiPassEncodingIfSupported
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("performsMultiPassEncodingIfSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPerformsMultiPassEncodingIfSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPerformsMultiPassEncodingIfSupportedHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPerformsMultiPassEncodingIfSupported:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPerformsMultiPassEncodingIfSupported_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPerformsMultiPassEncodingIfSupported_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint PreferredMediaChunkAlignment
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredMediaChunkAlignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredMediaChunkAlignmentHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredMediaChunkAlignmentHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CMTime PreferredMediaChunkDuration
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredMediaChunkDuration")]
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
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPreferredMediaChunkDuration:")]
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual float PreferredVolume
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("preferredVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
	public virtual bool ReadyForMoreMediaData
	{
		[Export("isReadyForMoreMediaData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyForMoreMediaDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyForMoreMediaDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSUrl? SampleReferenceBaseUrl
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sampleReferenceBaseURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleReferenceBaseURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleReferenceBaseURLHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	public virtual CMFormatDescription? SourceFormatHint
	{
		[Export("sourceFormatHint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return CMFormatDescription.Create(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceFormatHintHandle));
			}
			return CMFormatDescription.Create(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceFormatHintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform Transform
	{
		[Export("transform", ArgumentSemantic.Assign)]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTransformHandle);
			}
			return retval;
		}
		[Export("setTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetWriterInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetWriterInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMediaType:outputSettings:sourceFormatHint:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected AVAssetWriterInput(string mediaType, NSDictionary? outputSettings, CMFormatDescription? sourceFormatHint)
		: base(NSObjectFlag.Empty)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithMediaType_OutputSettings_SourceFormatHint_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero, sourceFormatHint?.Handle ?? IntPtr.Zero), "initWithMediaType:outputSettings:sourceFormatHint:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithMediaType_OutputSettings_SourceFormatHint_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero, sourceFormatHint?.Handle ?? IntPtr.Zero), "initWithMediaType:outputSettings:sourceFormatHint:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInput(string mediaType, AudioSettings? outputSettings, CMFormatDescription? sourceFormatHint)
		: this(mediaType, outputSettings.GetDictionary(), sourceFormatHint)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInput(string mediaType, AVVideoSettingsCompressed? outputSettings, CMFormatDescription? sourceFormatHint)
		: this(mediaType, outputSettings.GetDictionary(), sourceFormatHint)
	{
	}

	[Export("initWithMediaType:outputSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected AVAssetWriterInput(string mediaType, NSDictionary? outputSettings)
		: base(NSObjectFlag.Empty)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithMediaType_OutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero), "initWithMediaType:outputSettings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithMediaType_OutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero), "initWithMediaType:outputSettings:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInput(string mediaType, AudioSettings? outputSettings)
		: this(mediaType, outputSettings.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInput(string mediaType, AVVideoSettingsCompressed? outputSettings)
		: this(mediaType, outputSettings.GetDictionary())
	{
	}

	[Export("addTrackAssociationWithTrackOfInput:type:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTrackAssociationWithTrackOfInput(AVAssetWriterInput input, NSString trackAssociationType)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTrackAssociationWithTrackOfInput_Type_Handle, input.Handle, trackAssociationType.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTrackAssociationWithTrackOfInput_Type_Handle, input.Handle, trackAssociationType.Handle);
		}
	}

	[Export("appendSampleBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppendSampleBuffer(CMSampleBuffer sampleBuffer)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAppendSampleBuffer_Handle, sampleBuffer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendSampleBuffer_Handle, sampleBuffer.Handle);
	}

	[Export("canAddTrackAssociationWithTrackOfInput:type:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddTrackAssociationWithTrackOfInput(AVAssetWriterInput input, NSString trackAssociationType)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanAddTrackAssociationWithTrackOfInput_Type_Handle, input.Handle, trackAssociationType.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanAddTrackAssociationWithTrackOfInput_Type_Handle, input.Handle, trackAssociationType.Handle);
	}

	[Export("assetWriterInputWithMediaType:outputSettings:sourceFormatHint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVAssetWriterInput Create(string mediaType, NSDictionary? outputSettings, CMFormatDescription? sourceFormatHint)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVAssetWriterInput nSObject = Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero, sourceFormatHint?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInput Create(string mediaType, AudioSettings? outputSettings, CMFormatDescription? sourceFormatHint)
	{
		return Create(mediaType, outputSettings.GetDictionary(), sourceFormatHint);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInput Create(string mediaType, AVVideoSettingsCompressed? outputSettings, CMFormatDescription? sourceFormatHint)
	{
		return Create(mediaType, outputSettings.GetDictionary(), sourceFormatHint);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInput Create(string mediaType, AudioSettings? outputSettings)
	{
		return FromType(mediaType, outputSettings.GetDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInput Create(string mediaType, AVVideoSettingsCompressed? outputSettings)
	{
		return FromType(mediaType, outputSettings.GetDictionary());
	}

	[Export("assetWriterInputWithMediaType:outputSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use constructor or 'Create' method instead.")]
	internal static AVAssetWriterInput FromType(string mediaType, NSDictionary? outputSettings)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVAssetWriterInput nSObject = Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWriterInputWithMediaType_OutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("markAsFinished")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MarkAsFinished()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMarkAsFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMarkAsFinishedHandle);
		}
	}

	[Export("markCurrentPassAsFinished")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MarkCurrentPassAsFinished()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMarkCurrentPassAsFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMarkCurrentPassAsFinishedHandle);
		}
	}

	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestMediaData(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action action)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, action);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRequestMediaDataWhenReadyOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("respondToEachPassDescriptionOnQueue:usingBlock:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetPassHandler(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action passHandler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (passHandler == null)
		{
			throw new ArgumentNullException("passHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, passHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRespondToEachPassDescriptionOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRespondToEachPassDescriptionOnQueue_UsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
