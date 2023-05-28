using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCapturePhoto", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class AVCapturePhoto : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImageRepresentation = "CGImageRepresentation";

	private static readonly IntPtr selCGImageRepresentationHandle = Selector.GetHandle("CGImageRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraCalibrationData = "cameraCalibrationData";

	private static readonly IntPtr selCameraCalibrationDataHandle = Selector.GetHandle("cameraCalibrationData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileDataRepresentation = "fileDataRepresentation";

	private static readonly IntPtr selFileDataRepresentationHandle = Selector.GetHandle("fileDataRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoCount = "photoCount";

	private static readonly IntPtr selPhotoCountHandle = Selector.GetHandle("photoCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBuffer = "pixelBuffer";

	private static readonly IntPtr selPixelBufferHandle = Selector.GetHandle("pixelBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewCGImageRepresentation = "previewCGImageRepresentation";

	private static readonly IntPtr selPreviewCGImageRepresentationHandle = Selector.GetHandle("previewCGImageRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolvedSettings = "resolvedSettings";

	private static readonly IntPtr selResolvedSettingsHandle = Selector.GetHandle("resolvedSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceDeviceType = "sourceDeviceType";

	private static readonly IntPtr selSourceDeviceTypeHandle = Selector.GetHandle("sourceDeviceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimestamp = "timestamp";

	private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCapturePhoto");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CGImage? CGImageRepresentation
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("CGImageRepresentation")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGImageRepresentationHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGImageRepresentationHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCameraCalibrationData? CameraCalibrationData
	{
		[Export("cameraCalibrationData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCameraCalibrationData>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraCalibrationDataHandle));
			}
			return Runtime.GetNSObject<AVCameraCalibrationData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraCalibrationDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSData? FileDataRepresentation
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fileDataRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileDataRepresentationHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileDataRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PhotoCount
	{
		[Export("photoCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPhotoCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPhotoCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer? PixelBuffer
	{
		[Export("pixelBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CGImage? PreviewCGImageRepresentation
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("previewCGImageRepresentation")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewCGImageRepresentationHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewCGImageRepresentationHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureResolvedPhotoSettings ResolvedSettings
	{
		[Export("resolvedSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureResolvedPhotoSettings>(Messaging.IntPtr_objc_msgSend(base.Handle, selResolvedSettingsHandle));
			}
			return Runtime.GetNSObject<AVCaptureResolvedPhotoSettings>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResolvedSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCaptureDeviceType SourceDeviceType => AVCaptureDeviceTypeExtensions.GetValue(WeakSourceDeviceType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Timestamp
	{
		[Export("timestamp")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selTimestampHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimestampHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString? WeakSourceDeviceType
	{
		[Export("sourceDeviceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceDeviceTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceDeviceTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCapturePhoto(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCapturePhoto(IntPtr handle)
		: base(handle)
	{
	}
}
