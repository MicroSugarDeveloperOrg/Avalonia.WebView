using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCapturePhotoSettings", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class AVCapturePhotoSettings : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableEmbeddedThumbnailPhotoCodecTypes = "availableEmbeddedThumbnailPhotoCodecTypes";

	private static readonly IntPtr selAvailableEmbeddedThumbnailPhotoCodecTypesHandle = Selector.GetHandle("availableEmbeddedThumbnailPhotoCodecTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailablePreviewPhotoPixelFormatTypes = "availablePreviewPhotoPixelFormatTypes";

	private static readonly IntPtr selAvailablePreviewPhotoPixelFormatTypesHandle = Selector.GetHandle("availablePreviewPhotoPixelFormatTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmbeddedThumbnailPhotoFormat = "embeddedThumbnailPhotoFormat";

	private static readonly IntPtr selEmbeddedThumbnailPhotoFormatHandle = Selector.GetHandle("embeddedThumbnailPhotoFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmbedsDepthDataInPhoto = "embedsDepthDataInPhoto";

	private static readonly IntPtr selEmbedsDepthDataInPhotoHandle = Selector.GetHandle("embedsDepthDataInPhoto");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlashMode = "flashMode";

	private static readonly IntPtr selFlashModeHandle = Selector.GetHandle("flashMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutoDualCameraFusionEnabled = "isAutoDualCameraFusionEnabled";

	private static readonly IntPtr selIsAutoDualCameraFusionEnabledHandle = Selector.GetHandle("isAutoDualCameraFusionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCameraCalibrationDataDeliveryEnabled = "isCameraCalibrationDataDeliveryEnabled";

	private static readonly IntPtr selIsCameraCalibrationDataDeliveryEnabledHandle = Selector.GetHandle("isCameraCalibrationDataDeliveryEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDepthDataDeliveryEnabled = "isDepthDataDeliveryEnabled";

	private static readonly IntPtr selIsDepthDataDeliveryEnabledHandle = Selector.GetHandle("isDepthDataDeliveryEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDepthDataFiltered = "isDepthDataFiltered";

	private static readonly IntPtr selIsDepthDataFilteredHandle = Selector.GetHandle("isDepthDataFiltered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDualCameraDualPhotoDeliveryEnabled = "isDualCameraDualPhotoDeliveryEnabled";

	private static readonly IntPtr selIsDualCameraDualPhotoDeliveryEnabledHandle = Selector.GetHandle("isDualCameraDualPhotoDeliveryEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHighResolutionPhotoEnabled = "isHighResolutionPhotoEnabled";

	private static readonly IntPtr selIsHighResolutionPhotoEnabledHandle = Selector.GetHandle("isHighResolutionPhotoEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLivePhotoMovieFileURL = "livePhotoMovieFileURL";

	private static readonly IntPtr selLivePhotoMovieFileURLHandle = Selector.GetHandle("livePhotoMovieFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLivePhotoMovieMetadata = "livePhotoMovieMetadata";

	private static readonly IntPtr selLivePhotoMovieMetadataHandle = Selector.GetHandle("livePhotoMovieMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLivePhotoVideoCodecType = "livePhotoVideoCodecType";

	private static readonly IntPtr selLivePhotoVideoCodecTypeHandle = Selector.GetHandle("livePhotoVideoCodecType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettings = "photoSettings";

	private static readonly IntPtr selPhotoSettingsHandle = Selector.GetHandle("photoSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettingsFromPhotoSettings_ = "photoSettingsFromPhotoSettings:";

	private static readonly IntPtr selPhotoSettingsFromPhotoSettings_Handle = Selector.GetHandle("photoSettingsFromPhotoSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettingsWithFormat_ = "photoSettingsWithFormat:";

	private static readonly IntPtr selPhotoSettingsWithFormat_Handle = Selector.GetHandle("photoSettingsWithFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettingsWithRawPixelFormatType_ = "photoSettingsWithRawPixelFormatType:";

	private static readonly IntPtr selPhotoSettingsWithRawPixelFormatType_Handle = Selector.GetHandle("photoSettingsWithRawPixelFormatType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_ = "photoSettingsWithRawPixelFormatType:processedFormat:";

	private static readonly IntPtr selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_Handle = Selector.GetHandle("photoSettingsWithRawPixelFormatType:processedFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_ = "photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:";

	private static readonly IntPtr selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_Handle = Selector.GetHandle("photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewPhotoFormat = "previewPhotoFormat";

	private static readonly IntPtr selPreviewPhotoFormatHandle = Selector.GetHandle("previewPhotoFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessedFileType = "processedFileType";

	private static readonly IntPtr selProcessedFileTypeHandle = Selector.GetHandle("processedFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRawFileType = "rawFileType";

	private static readonly IntPtr selRawFileTypeHandle = Selector.GetHandle("rawFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRawPhotoPixelFormatType = "rawPhotoPixelFormatType";

	private static readonly IntPtr selRawPhotoPixelFormatTypeHandle = Selector.GetHandle("rawPhotoPixelFormatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoDualCameraFusionEnabled_ = "setAutoDualCameraFusionEnabled:";

	private static readonly IntPtr selSetAutoDualCameraFusionEnabled_Handle = Selector.GetHandle("setAutoDualCameraFusionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraCalibrationDataDeliveryEnabled_ = "setCameraCalibrationDataDeliveryEnabled:";

	private static readonly IntPtr selSetCameraCalibrationDataDeliveryEnabled_Handle = Selector.GetHandle("setCameraCalibrationDataDeliveryEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthDataDeliveryEnabled_ = "setDepthDataDeliveryEnabled:";

	private static readonly IntPtr selSetDepthDataDeliveryEnabled_Handle = Selector.GetHandle("setDepthDataDeliveryEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthDataFiltered_ = "setDepthDataFiltered:";

	private static readonly IntPtr selSetDepthDataFiltered_Handle = Selector.GetHandle("setDepthDataFiltered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDualCameraDualPhotoDeliveryEnabled_ = "setDualCameraDualPhotoDeliveryEnabled:";

	private static readonly IntPtr selSetDualCameraDualPhotoDeliveryEnabled_Handle = Selector.GetHandle("setDualCameraDualPhotoDeliveryEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmbeddedThumbnailPhotoFormat_ = "setEmbeddedThumbnailPhotoFormat:";

	private static readonly IntPtr selSetEmbeddedThumbnailPhotoFormat_Handle = Selector.GetHandle("setEmbeddedThumbnailPhotoFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmbedsDepthDataInPhoto_ = "setEmbedsDepthDataInPhoto:";

	private static readonly IntPtr selSetEmbedsDepthDataInPhoto_Handle = Selector.GetHandle("setEmbedsDepthDataInPhoto:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlashMode_ = "setFlashMode:";

	private static readonly IntPtr selSetFlashMode_Handle = Selector.GetHandle("setFlashMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighResolutionPhotoEnabled_ = "setHighResolutionPhotoEnabled:";

	private static readonly IntPtr selSetHighResolutionPhotoEnabled_Handle = Selector.GetHandle("setHighResolutionPhotoEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLivePhotoMovieFileURL_ = "setLivePhotoMovieFileURL:";

	private static readonly IntPtr selSetLivePhotoMovieFileURL_Handle = Selector.GetHandle("setLivePhotoMovieFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLivePhotoMovieMetadata_ = "setLivePhotoMovieMetadata:";

	private static readonly IntPtr selSetLivePhotoMovieMetadata_Handle = Selector.GetHandle("setLivePhotoMovieMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLivePhotoVideoCodecType_ = "setLivePhotoVideoCodecType:";

	private static readonly IntPtr selSetLivePhotoVideoCodecType_Handle = Selector.GetHandle("setLivePhotoVideoCodecType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviewPhotoFormat_ = "setPreviewPhotoFormat:";

	private static readonly IntPtr selSetPreviewPhotoFormat_Handle = Selector.GetHandle("setPreviewPhotoFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueID = "uniqueID";

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCapturePhotoSettings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AutoVirtualDeviceFusionEnabled' instead.")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	public virtual bool AutoDualCameraFusionEnabled
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AutoVirtualDeviceFusionEnabled' instead.")]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("isAutoDualCameraFusionEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutoDualCameraFusionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutoDualCameraFusionEnabledHandle);
		}
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AutoVirtualDeviceFusionEnabled' instead.")]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("setAutoDualCameraFusionEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoDualCameraFusionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoDualCameraFusionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual AVVideoCodecType[] AvailableEmbeddedThumbnailPhotoCodecTypes
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return Array.ConvertAll(_GetAvailableEmbeddedThumbnailPhotoCodecTypes, (NSString s) => AVVideoCodecTypeExtensions.GetValue(s));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] AvailablePreviewPhotoPixelFormatTypes
	{
		[Export("availablePreviewPhotoPixelFormatTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailablePreviewPhotoPixelFormatTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailablePreviewPhotoPixelFormatTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool CameraCalibrationDataDeliveryEnabled
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isCameraCalibrationDataDeliveryEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCameraCalibrationDataDeliveryEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCameraCalibrationDataDeliveryEnabledHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setCameraCalibrationDataDeliveryEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCameraCalibrationDataDeliveryEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCameraCalibrationDataDeliveryEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool DepthDataDeliveryEnabled
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isDepthDataDeliveryEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDepthDataDeliveryEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDepthDataDeliveryEnabledHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDepthDataDeliveryEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDepthDataDeliveryEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDepthDataDeliveryEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool DepthDataFiltered
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isDepthDataFiltered")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDepthDataFilteredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDepthDataFilteredHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDepthDataFiltered:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDepthDataFiltered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDepthDataFiltered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool DualCameraDualPhotoDeliveryEnabled
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isDualCameraDualPhotoDeliveryEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDualCameraDualPhotoDeliveryEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDualCameraDualPhotoDeliveryEnabledHandle);
		}
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'VirtualDeviceConstituentPhotoDeliveryEnabled' instead.")]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDualCameraDualPhotoDeliveryEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDualCameraDualPhotoDeliveryEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDualCameraDualPhotoDeliveryEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSDictionary? EmbeddedThumbnailPhotoFormat
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("embeddedThumbnailPhotoFormat", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmbeddedThumbnailPhotoFormatHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmbeddedThumbnailPhotoFormatHandle));
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setEmbeddedThumbnailPhotoFormat:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmbeddedThumbnailPhotoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmbeddedThumbnailPhotoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool EmbedsDepthDataInPhoto
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("embedsDepthDataInPhoto")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEmbedsDepthDataInPhotoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEmbedsDepthDataInPhotoHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setEmbedsDepthDataInPhoto:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEmbedsDepthDataInPhoto_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEmbedsDepthDataInPhoto_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureFlashMode FlashMode
	{
		[Export("flashMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureFlashMode)Messaging.Int64_objc_msgSend(base.Handle, selFlashModeHandle);
			}
			return (AVCaptureFlashMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFlashModeHandle);
		}
		[Export("setFlashMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFlashMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFlashMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>? Format
	{
		[Export("format", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'AvailableEmbeddedThumbnailPhotoCodecTypes' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public AVVideoCodecType[] GetAvailableEmbeddedThumbnailPhotoCodecTypes
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return Array.ConvertAll(_GetAvailableEmbeddedThumbnailPhotoCodecTypes, (NSString s) => AVVideoCodecTypeExtensions.GetValue(s));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsHighResolutionPhotoEnabled
	{
		[Export("isHighResolutionPhotoEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHighResolutionPhotoEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHighResolutionPhotoEnabledHandle);
		}
		[Export("setHighResolutionPhotoEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHighResolutionPhotoEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHighResolutionPhotoEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? LivePhotoMovieFileUrl
	{
		[Export("livePhotoMovieFileURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selLivePhotoMovieFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLivePhotoMovieFileURLHandle));
		}
		[Export("setLivePhotoMovieFileURL:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLivePhotoMovieFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLivePhotoMovieFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[]? LivePhotoMovieMetadata
	{
		[Export("livePhotoMovieMetadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selLivePhotoMovieMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLivePhotoMovieMetadataHandle));
		}
		[Export("setLivePhotoMovieMetadata:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLivePhotoMovieMetadata_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLivePhotoMovieMetadata_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string LivePhotoVideoCodecType
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("livePhotoVideoCodecType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLivePhotoVideoCodecTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLivePhotoVideoCodecTypeHandle));
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setLivePhotoVideoCodecType:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLivePhotoVideoCodecType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLivePhotoVideoCodecType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSDictionary Metadata
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>? PreviewPhotoFormat
	{
		[Export("previewPhotoFormat", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewPhotoFormatHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewPhotoFormatHandle));
		}
		[Export("setPreviewPhotoFormat:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreviewPhotoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreviewPhotoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? ProcessedFileType
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("processedFileType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProcessedFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProcessedFileTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? RawFileType
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("rawFileType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRawFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRawFileTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint RawPhotoPixelFormatType
	{
		[Export("rawPhotoPixelFormatType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selRawPhotoPixelFormatTypeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selRawPhotoPixelFormatTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long UniqueID
	{
		[Export("uniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selUniqueIDHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSString[] _GetAvailableEmbeddedThumbnailPhotoCodecTypes
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("availableEmbeddedThumbnailPhotoCodecTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableEmbeddedThumbnailPhotoCodecTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableEmbeddedThumbnailPhotoCodecTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCapturePhotoSettings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCapturePhotoSettings(IntPtr handle)
		: base(handle)
	{
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

	[Export("photoSettings")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings Create()
	{
		return Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend(class_ptr, selPhotoSettingsHandle));
	}

	[Export("photoSettingsWithFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings FromFormat(NSDictionary<NSString, NSObject>? format)
	{
		return Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPhotoSettingsWithFormat_Handle, format?.Handle ?? IntPtr.Zero));
	}

	[Export("photoSettingsFromPhotoSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings FromPhotoSettings(AVCapturePhotoSettings photoSettings)
	{
		if (photoSettings == null)
		{
			throw new ArgumentNullException("photoSettings");
		}
		return Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPhotoSettingsFromPhotoSettings_Handle, photoSettings.Handle));
	}

	[Export("photoSettingsWithRawPixelFormatType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings FromRawPixelFormatType(uint rawPixelFormatType)
	{
		return Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selPhotoSettingsWithRawPixelFormatType_Handle, rawPixelFormatType));
	}

	[Export("photoSettingsWithRawPixelFormatType:processedFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings FromRawPixelFormatType(uint rawPixelFormatType, NSDictionary<NSString, NSObject>? processedFormat)
	{
		return Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr(class_ptr, selPhotoSettingsWithRawPixelFormatType_ProcessedFormat_Handle, rawPixelFormatType, processedFormat?.Handle ?? IntPtr.Zero));
	}

	[Export("photoSettingsWithRawPixelFormatType:rawFileType:processedFormat:processedFileType:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCapturePhotoSettings FromRawPixelFormatType(uint rawPixelFormatType, string? rawFileType, NSDictionary<NSString, NSObject>? processedFormat, string? processedFileType)
	{
		IntPtr arg = NSString.CreateNative(rawFileType);
		IntPtr arg2 = NSString.CreateNative(processedFileType);
		AVCapturePhotoSettings nSObject = Runtime.GetNSObject<AVCapturePhotoSettings>(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr(class_ptr, selPhotoSettingsWithRawPixelFormatType_RawFileType_ProcessedFormat_ProcessedFileType_Handle, rawPixelFormatType, arg, processedFormat?.Handle ?? IntPtr.Zero, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}
}
