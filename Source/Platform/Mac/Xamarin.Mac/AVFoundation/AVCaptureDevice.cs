using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDevice", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVCaptureDevice : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveWasConnected(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasConnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasConnected(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasConnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasDisconnected(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDisconnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasDisconnected(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDisconnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveColorSpace = "activeColorSpace";

	private static readonly IntPtr selActiveColorSpaceHandle = Selector.GetHandle("activeColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveFormat = "activeFormat";

	private static readonly IntPtr selActiveFormatHandle = Selector.GetHandle("activeFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveInputSource = "activeInputSource";

	private static readonly IntPtr selActiveInputSourceHandle = Selector.GetHandle("activeInputSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveVideoMaxFrameDuration = "activeVideoMaxFrameDuration";

	private static readonly IntPtr selActiveVideoMaxFrameDurationHandle = Selector.GetHandle("activeVideoMaxFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveVideoMinFrameDuration = "activeVideoMinFrameDuration";

	private static readonly IntPtr selActiveVideoMinFrameDurationHandle = Selector.GetHandle("activeVideoMinFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatusForMediaType_ = "authorizationStatusForMediaType:";

	private static readonly IntPtr selAuthorizationStatusForMediaType_Handle = Selector.GetHandle("authorizationStatusForMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDeviceWithDeviceType_MediaType_Position_ = "defaultDeviceWithDeviceType:mediaType:position:";

	private static readonly IntPtr selDefaultDeviceWithDeviceType_MediaType_Position_Handle = Selector.GetHandle("defaultDeviceWithDeviceType:mediaType:position:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDeviceWithMediaType_ = "defaultDeviceWithMediaType:";

	private static readonly IntPtr selDefaultDeviceWithMediaType_Handle = Selector.GetHandle("defaultDeviceWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceType = "deviceType";

	private static readonly IntPtr selDeviceTypeHandle = Selector.GetHandle("deviceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceWithUniqueID_ = "deviceWithUniqueID:";

	private static readonly IntPtr selDeviceWithUniqueID_Handle = Selector.GetHandle("deviceWithUniqueID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevices = "devices";

	private static readonly IntPtr selDevicesHandle = Selector.GetHandle("devices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevicesWithMediaType_ = "devicesWithMediaType:";

	private static readonly IntPtr selDevicesWithMediaType_Handle = Selector.GetHandle("devicesWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposureMode = "exposureMode";

	private static readonly IntPtr selExposureModeHandle = Selector.GetHandle("exposureMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposurePointOfInterest = "exposurePointOfInterest";

	private static readonly IntPtr selExposurePointOfInterestHandle = Selector.GetHandle("exposurePointOfInterest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlashMode = "flashMode";

	private static readonly IntPtr selFlashModeHandle = Selector.GetHandle("flashMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusMode = "focusMode";

	private static readonly IntPtr selFocusModeHandle = Selector.GetHandle("focusMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusPointOfInterest = "focusPointOfInterest";

	private static readonly IntPtr selFocusPointOfInterestHandle = Selector.GetHandle("focusPointOfInterest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormats = "formats";

	private static readonly IntPtr selFormatsHandle = Selector.GetHandle("formats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasFlash = "hasFlash";

	private static readonly IntPtr selHasFlashHandle = Selector.GetHandle("hasFlash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMediaType_ = "hasMediaType:";

	private static readonly IntPtr selHasMediaType_Handle = Selector.GetHandle("hasMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasTorch = "hasTorch";

	private static readonly IntPtr selHasTorchHandle = Selector.GetHandle("hasTorch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputSources = "inputSources";

	private static readonly IntPtr selInputSourcesHandle = Selector.GetHandle("inputSources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdjustingExposure = "isAdjustingExposure";

	private static readonly IntPtr selIsAdjustingExposureHandle = Selector.GetHandle("isAdjustingExposure");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdjustingFocus = "isAdjustingFocus";

	private static readonly IntPtr selIsAdjustingFocusHandle = Selector.GetHandle("isAdjustingFocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdjustingWhiteBalance = "isAdjustingWhiteBalance";

	private static readonly IntPtr selIsAdjustingWhiteBalanceHandle = Selector.GetHandle("isAdjustingWhiteBalance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConnected = "isConnected";

	private static readonly IntPtr selIsConnectedHandle = Selector.GetHandle("isConnected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExposureModeSupported_ = "isExposureModeSupported:";

	private static readonly IntPtr selIsExposureModeSupported_Handle = Selector.GetHandle("isExposureModeSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExposurePointOfInterestSupported = "isExposurePointOfInterestSupported";

	private static readonly IntPtr selIsExposurePointOfInterestSupportedHandle = Selector.GetHandle("isExposurePointOfInterestSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlashAvailable = "isFlashAvailable";

	private static readonly IntPtr selIsFlashAvailableHandle = Selector.GetHandle("isFlashAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlashModeSupported_ = "isFlashModeSupported:";

	private static readonly IntPtr selIsFlashModeSupported_Handle = Selector.GetHandle("isFlashModeSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFocusModeSupported_ = "isFocusModeSupported:";

	private static readonly IntPtr selIsFocusModeSupported_Handle = Selector.GetHandle("isFocusModeSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFocusPointOfInterestSupported = "isFocusPointOfInterestSupported";

	private static readonly IntPtr selIsFocusPointOfInterestSupportedHandle = Selector.GetHandle("isFocusPointOfInterestSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInUseByAnotherApplication = "isInUseByAnotherApplication";

	private static readonly IntPtr selIsInUseByAnotherApplicationHandle = Selector.GetHandle("isInUseByAnotherApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSuspended = "isSuspended";

	private static readonly IntPtr selIsSuspendedHandle = Selector.GetHandle("isSuspended");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTorchActive = "isTorchActive";

	private static readonly IntPtr selIsTorchActiveHandle = Selector.GetHandle("isTorchActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTorchAvailable = "isTorchAvailable";

	private static readonly IntPtr selIsTorchAvailableHandle = Selector.GetHandle("isTorchAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTorchModeSupported_ = "isTorchModeSupported:";

	private static readonly IntPtr selIsTorchModeSupported_Handle = Selector.GetHandle("isTorchModeSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsWhiteBalanceModeSupported_ = "isWhiteBalanceModeSupported:";

	private static readonly IntPtr selIsWhiteBalanceModeSupported_Handle = Selector.GetHandle("isWhiteBalanceModeSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkedDevices = "linkedDevices";

	private static readonly IntPtr selLinkedDevicesHandle = Selector.GetHandle("linkedDevices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockForConfiguration_ = "lockForConfiguration:";

	private static readonly IntPtr selLockForConfiguration_Handle = Selector.GetHandle("lockForConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManufacturer = "manufacturer";

	private static readonly IntPtr selManufacturerHandle = Selector.GetHandle("manufacturer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelID = "modelID";

	private static readonly IntPtr selModelIDHandle = Selector.GetHandle("modelID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAccessForMediaType_CompletionHandler_ = "requestAccessForMediaType:completionHandler:";

	private static readonly IntPtr selRequestAccessForMediaType_CompletionHandler_Handle = Selector.GetHandle("requestAccessForMediaType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActiveColorSpace_ = "setActiveColorSpace:";

	private static readonly IntPtr selSetActiveColorSpace_Handle = Selector.GetHandle("setActiveColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActiveFormat_ = "setActiveFormat:";

	private static readonly IntPtr selSetActiveFormat_Handle = Selector.GetHandle("setActiveFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActiveInputSource_ = "setActiveInputSource:";

	private static readonly IntPtr selSetActiveInputSource_Handle = Selector.GetHandle("setActiveInputSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActiveVideoMaxFrameDuration_ = "setActiveVideoMaxFrameDuration:";

	private static readonly IntPtr selSetActiveVideoMaxFrameDuration_Handle = Selector.GetHandle("setActiveVideoMaxFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActiveVideoMinFrameDuration_ = "setActiveVideoMinFrameDuration:";

	private static readonly IntPtr selSetActiveVideoMinFrameDuration_Handle = Selector.GetHandle("setActiveVideoMinFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExposureMode_ = "setExposureMode:";

	private static readonly IntPtr selSetExposureMode_Handle = Selector.GetHandle("setExposureMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExposurePointOfInterest_ = "setExposurePointOfInterest:";

	private static readonly IntPtr selSetExposurePointOfInterest_Handle = Selector.GetHandle("setExposurePointOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlashMode_ = "setFlashMode:";

	private static readonly IntPtr selSetFlashMode_Handle = Selector.GetHandle("setFlashMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocusMode_ = "setFocusMode:";

	private static readonly IntPtr selSetFocusMode_Handle = Selector.GetHandle("setFocusMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocusPointOfInterest_ = "setFocusPointOfInterest:";

	private static readonly IntPtr selSetFocusPointOfInterest_Handle = Selector.GetHandle("setFocusPointOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTorchMode_ = "setTorchMode:";

	private static readonly IntPtr selSetTorchMode_Handle = Selector.GetHandle("setTorchMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTorchModeOnWithLevel_Error_ = "setTorchModeOnWithLevel:error:";

	private static readonly IntPtr selSetTorchModeOnWithLevel_Error_Handle = Selector.GetHandle("setTorchModeOnWithLevel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransportControlsPlaybackMode_Speed_ = "setTransportControlsPlaybackMode:speed:";

	private static readonly IntPtr selSetTransportControlsPlaybackMode_Speed_Handle = Selector.GetHandle("setTransportControlsPlaybackMode:speed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWhiteBalanceMode_ = "setWhiteBalanceMode:";

	private static readonly IntPtr selSetWhiteBalanceMode_Handle = Selector.GetHandle("setWhiteBalanceMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsAVCaptureSessionPreset_ = "supportsAVCaptureSessionPreset:";

	private static readonly IntPtr selSupportsAVCaptureSessionPreset_Handle = Selector.GetHandle("supportsAVCaptureSessionPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTorchLevel = "torchLevel";

	private static readonly IntPtr selTorchLevelHandle = Selector.GetHandle("torchLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTorchMode = "torchMode";

	private static readonly IntPtr selTorchModeHandle = Selector.GetHandle("torchMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportControlsPlaybackMode = "transportControlsPlaybackMode";

	private static readonly IntPtr selTransportControlsPlaybackModeHandle = Selector.GetHandle("transportControlsPlaybackMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportControlsSpeed = "transportControlsSpeed";

	private static readonly IntPtr selTransportControlsSpeedHandle = Selector.GetHandle("transportControlsSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportControlsSupported = "transportControlsSupported";

	private static readonly IntPtr selTransportControlsSupportedHandle = Selector.GetHandle("transportControlsSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportType = "transportType";

	private static readonly IntPtr selTransportTypeHandle = Selector.GetHandle("transportType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueID = "uniqueID";

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockForConfiguration = "unlockForConfiguration";

	private static readonly IntPtr selUnlockForConfigurationHandle = Selector.GetHandle("unlockForConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhiteBalanceMode = "whiteBalanceMode";

	private static readonly IntPtr selWhiteBalanceModeHandle = Selector.GetHandle("whiteBalanceMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasConnectedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasDisconnectedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual AVCaptureColorSpace ActiveColorSpace
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("activeColorSpace", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureColorSpace)Messaging.Int64_objc_msgSend(base.Handle, selActiveColorSpaceHandle);
			}
			return (AVCaptureColorSpace)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selActiveColorSpaceHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setActiveColorSpace:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetActiveColorSpace_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetActiveColorSpace_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureDeviceFormat ActiveFormat
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("activeFormat", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureDeviceFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveFormatHandle));
			}
			return Runtime.GetNSObject<AVCaptureDeviceFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveFormatHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setActiveFormat:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActiveFormat_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActiveFormat_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureDeviceInputSource? ActiveInputSource
	{
		[Export("activeInputSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureDeviceInputSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveInputSourceHandle));
			}
			return Runtime.GetNSObject<AVCaptureDeviceInputSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveInputSourceHandle));
		}
		[Export("setActiveInputSource:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActiveInputSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActiveInputSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CMTime ActiveVideoMaxFrameDuration
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("activeVideoMaxFrameDuration", ArgumentSemantic.Copy)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selActiveVideoMaxFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selActiveVideoMaxFrameDurationHandle);
			}
			return retval;
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setActiveVideoMaxFrameDuration:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetActiveVideoMaxFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetActiveVideoMaxFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CMTime ActiveVideoMinFrameDuration
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("activeVideoMinFrameDuration", ArgumentSemantic.Copy)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selActiveVideoMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selActiveVideoMinFrameDurationHandle);
			}
			return retval;
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setActiveVideoMinFrameDuration:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetActiveVideoMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetActiveVideoMinFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool AdjustingExposure
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isAdjustingExposure")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingExposureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingExposureHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool AdjustingFocus
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isAdjustingFocus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingFocusHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingFocusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool AdjustingWhiteBalance
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isAdjustingWhiteBalance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingWhiteBalanceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingWhiteBalanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool Connected
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isConnected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConnectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConnectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public AVCaptureDeviceType DeviceType
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			return AVCaptureDeviceTypeExtensions.GetValue(_DeviceType);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
	public static AVCaptureDevice[] Devices
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
		[Export("devices")]
		get
		{
			return NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend(class_ptr, selDevicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureExposureMode ExposureMode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("exposureMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureExposureMode)Messaging.Int64_objc_msgSend(base.Handle, selExposureModeHandle);
			}
			return (AVCaptureExposureMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selExposureModeHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setExposureMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetExposureMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetExposureMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual CGPoint ExposurePointOfInterest
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("exposurePointOfInterest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selExposurePointOfInterestHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selExposurePointOfInterestHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setExposurePointOfInterest:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetExposurePointOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetExposurePointOfInterest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool ExposurePointOfInterestSupported
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isExposurePointOfInterestSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExposurePointOfInterestSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExposurePointOfInterestSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool FlashAvailable
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isFlashAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlashAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlashAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Use 'AVCapturePhotoSettings.FlashMode' instead.")]
	public virtual AVCaptureFlashMode FlashMode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Use 'AVCapturePhotoSettings.FlashMode' instead.")]
		[Export("flashMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureFlashMode)Messaging.Int64_objc_msgSend(base.Handle, selFlashModeHandle);
			}
			return (AVCaptureFlashMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFlashModeHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Use 'AVCapturePhotoSettings.FlashMode' instead.")]
		[Export("setFlashMode:")]
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
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureFocusMode FocusMode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("focusMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureFocusMode)Messaging.Int64_objc_msgSend(base.Handle, selFocusModeHandle);
			}
			return (AVCaptureFocusMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFocusModeHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setFocusMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFocusMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFocusMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual CGPoint FocusPointOfInterest
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("focusPointOfInterest", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selFocusPointOfInterestHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selFocusPointOfInterestHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setFocusPointOfInterest:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFocusPointOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFocusPointOfInterest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool FocusPointOfInterestSupported
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isFocusPointOfInterestSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFocusPointOfInterestSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFocusPointOfInterestSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureDeviceFormat[] Formats
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("formats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureDeviceFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureDeviceFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool HasFlash
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("hasFlash")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasFlashHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasFlashHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool HasTorch
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("hasTorch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasTorchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasTorchHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool InUseByAnotherApplication
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isInUseByAnotherApplication")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInUseByAnotherApplicationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInUseByAnotherApplicationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureDeviceInputSource[] InputSources
	{
		[Export("inputSources")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureDeviceInputSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputSourcesHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureDeviceInputSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputSourcesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureDevice[] LinkedDevices
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("linkedDevices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selLinkedDevicesHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinkedDevicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string LocalizedName
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("localizedName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string Manufacturer
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("manufacturer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selManufacturerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManufacturerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string ModelID
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("modelID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModelIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureDevicePosition Position
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("position")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureDevicePosition)Messaging.Int64_objc_msgSend(base.Handle, selPositionHandle);
			}
			return (AVCaptureDevicePosition)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool Suspended
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("isSuspended")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSuspendedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool TorchActive
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isTorchActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTorchActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTorchActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool TorchAvailable
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isTorchAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTorchAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTorchAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual float TorchLevel
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("torchLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTorchLevelHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTorchLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureTorchMode TorchMode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("torchMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureTorchMode)Messaging.Int64_objc_msgSend(base.Handle, selTorchModeHandle);
			}
			return (AVCaptureTorchMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTorchModeHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setTorchMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTorchMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTorchMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureDeviceTransportControlsPlaybackMode TransportControlsPlaybackMode
	{
		[Export("transportControlsPlaybackMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureDeviceTransportControlsPlaybackMode)Messaging.Int64_objc_msgSend(base.Handle, selTransportControlsPlaybackModeHandle);
			}
			return (AVCaptureDeviceTransportControlsPlaybackMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransportControlsPlaybackModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual float TransportControlsSpeed
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("transportControlsSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTransportControlsSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTransportControlsSpeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool TransportControlsSupported
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("transportControlsSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTransportControlsSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTransportControlsSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string UniqueID
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("uniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public virtual int WeakTransportType
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("transportType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTransportTypeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTransportTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVCaptureWhiteBalanceMode WhiteBalanceMode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("whiteBalanceMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureWhiteBalanceMode)Messaging.Int64_objc_msgSend(base.Handle, selWhiteBalanceModeHandle);
			}
			return (AVCaptureWhiteBalanceMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWhiteBalanceModeHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setWhiteBalanceMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWhiteBalanceMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWhiteBalanceMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	internal virtual NSString _DeviceType
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("deviceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceTypeHandle));
		}
	}

	[Field("AVCaptureMaxAvailableTorchLevel", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static float MaxAvailableTorchLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetFloat(Libraries.AVFoundation.Handle, "AVCaptureMaxAvailableTorchLevel");
		}
	}

	[Field("AVCaptureDeviceWasConnectedNotification", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Advice("Use AVCaptureDevice.Notifications.ObserveWasConnected helper method instead.")]
	public static NSString WasConnectedNotification
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_WasConnectedNotification == null)
			{
				_WasConnectedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureDeviceWasConnectedNotification");
			}
			return _WasConnectedNotification;
		}
	}

	[Field("AVCaptureDeviceWasDisconnectedNotification", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Advice("Use AVCaptureDevice.Notifications.ObserveWasDisconnected helper method instead.")]
	public static NSString WasDisconnectedNotification
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_WasDisconnectedNotification == null)
			{
				_WasDisconnectedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureDeviceWasDisconnectedNotification");
			}
			return _WasDisconnectedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Obsolete("Use 'GetDefaultDevice (AVMediaTypes)'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice? DefaultDeviceWithMediaType(string mediaType)
	{
		return GetDefaultDevice((NSString)mediaType);
	}

	[Export("deviceWithUniqueID:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice? DeviceWithUniqueID(string deviceUniqueID)
	{
		if (deviceUniqueID == null)
		{
			throw new ArgumentNullException("deviceUniqueID");
		}
		IntPtr arg = NSString.CreateNative(deviceUniqueID);
		AVCaptureDevice nSObject = Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceWithUniqueID_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("devicesWithMediaType:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AVCaptureDeviceDiscoverySession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice[] DevicesWithMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVCaptureDevice[] result = NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDevicesWithMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAuthorizationStatus GetAuthorizationStatus(AVAuthorizationMediaType mediaType)
	{
		return GetAuthorizationStatus((mediaType == AVAuthorizationMediaType.Video) ? AVMediaTypes.Video.GetConstant() : AVMediaTypes.Audio.GetConstant());
	}

	[Export("authorizationStatusForMediaType:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAuthorizationStatus GetAuthorizationStatus(NSString avMediaTypeToken)
	{
		if (avMediaTypeToken == null)
		{
			throw new ArgumentNullException("avMediaTypeToken");
		}
		return (AVAuthorizationStatus)Messaging.Int64_objc_msgSend_IntPtr(class_ptr, selAuthorizationStatusForMediaType_Handle, avMediaTypeToken.Handle);
	}

	[Export("defaultDeviceWithMediaType:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice? GetDefaultDevice(NSString mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		return Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultDeviceWithMediaType_Handle, mediaType.Handle));
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice? GetDefaultDevice(AVMediaTypes mediaType)
	{
		return GetDefaultDevice(mediaType.GetConstant());
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice GetDefaultDevice(AVCaptureDeviceType deviceType, string mediaType, AVCaptureDevicePosition position)
	{
		return _DefaultDeviceWithDeviceType(deviceType.GetConstant(), mediaType, position);
	}

	[Export("defaultDeviceWithDeviceType:mediaType:position:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureDevice? GetDefaultDevice([BindAs(typeof(AVCaptureDeviceType), OriginalType = typeof(NSString))] AVCaptureDeviceType deviceType, [BindAs(typeof(AVMediaTypes), OriginalType = typeof(NSString))] AVMediaTypes mediaType, AVCaptureDevicePosition position)
	{
		NSString constant = deviceType.GetConstant();
		NSString constant2 = mediaType.GetConstant();
		return Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(class_ptr, selDefaultDeviceWithDeviceType_MediaType_Position_Handle, (constant == null) ? IntPtr.Zero : constant.Handle, (constant2 == null) ? IntPtr.Zero : constant2.Handle, (long)position));
	}

	[Export("hasMediaType:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaType_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool HasMediaType(AVMediaTypes mediaType)
	{
		return HasMediaType(mediaType.GetConstant());
	}

	[Export("isExposureModeSupported:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsExposureModeSupported(AVCaptureExposureMode exposureMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsExposureModeSupported_Handle, (long)exposureMode);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsExposureModeSupported_Handle, (long)exposureMode);
	}

	[Export("isFlashModeSupported:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Use 'AVCapturePhotoOutput.SupportedFlashModes' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFlashModeSupported(AVCaptureFlashMode flashMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsFlashModeSupported_Handle, (long)flashMode);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsFlashModeSupported_Handle, (long)flashMode);
	}

	[Export("isFocusModeSupported:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFocusModeSupported(AVCaptureFocusMode focusMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsFocusModeSupported_Handle, (long)focusMode);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsFocusModeSupported_Handle, (long)focusMode);
	}

	[Export("isTorchModeSupported:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsTorchModeSupported(AVCaptureTorchMode torchMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsTorchModeSupported_Handle, (long)torchMode);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsTorchModeSupported_Handle, (long)torchMode);
	}

	[Export("isWhiteBalanceModeSupported:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsWhiteBalanceModeSupported(AVCaptureWhiteBalanceMode whiteBalanceMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsWhiteBalanceModeSupported_Handle, (long)whiteBalanceMode);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsWhiteBalanceModeSupported_Handle, (long)whiteBalanceMode);
	}

	[Export("lockForConfiguration:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LockForConfiguration(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selLockForConfiguration_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selLockForConfiguration_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestAccessForMediaType(AVAuthorizationMediaType mediaType, [BlockProxy(typeof(Trampolines.NIDAVRequestAccessStatus))] AVRequestAccessStatus completion)
	{
		RequestAccessForMediaType((mediaType == AVAuthorizationMediaType.Video) ? AVMediaTypes.Video.GetConstant() : AVMediaTypes.Audio.GetConstant(), completion);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<bool> RequestAccessForMediaTypeAsync(AVAuthorizationMediaType mediaType)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RequestAccessForMediaType(mediaType, delegate(bool accessGranted_)
		{
			tcs.SetResult(accessGranted_);
		});
		return tcs.Task;
	}

	[Export("requestAccessForMediaType:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RequestAccessForMediaType(NSString avMediaTypeToken, [BlockProxy(typeof(Trampolines.NIDAVRequestAccessStatus))] AVRequestAccessStatus completion)
	{
		if (avMediaTypeToken == null)
		{
			throw new ArgumentNullException("avMediaTypeToken");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVRequestAccessStatus.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRequestAccessForMediaType_CompletionHandler_Handle, avMediaTypeToken.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<bool> RequestAccessForMediaTypeAsync(NSString avMediaTypeToken)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RequestAccessForMediaType(avMediaTypeToken, delegate(bool accessGranted_)
		{
			tcs.SetResult(accessGranted_);
		});
		return tcs.Task;
	}

	[Export("setTorchModeOnWithLevel:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetTorchModeLevel(float torchLevel, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_float_ref_IntPtr(base.SuperHandle, selSetTorchModeOnWithLevel_Error_Handle, torchLevel, ref arg) : Messaging.bool_objc_msgSend_float_ref_IntPtr(base.Handle, selSetTorchModeOnWithLevel_Error_Handle, torchLevel, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setTransportControlsPlaybackMode:speed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTransportControlsPlaybackMode(AVCaptureDeviceTransportControlsPlaybackMode mode, float speed)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_float(base.Handle, selSetTransportControlsPlaybackMode_Speed_Handle, (long)mode, speed);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_float(base.SuperHandle, selSetTransportControlsPlaybackMode_Speed_Handle, (long)mode, speed);
		}
	}

	[Export("supportsAVCaptureSessionPreset:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsAVCaptureSessionPreset(string preset)
	{
		if (preset == null)
		{
			throw new ArgumentNullException("preset");
		}
		IntPtr arg = NSString.CreateNative(preset);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSupportsAVCaptureSessionPreset_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSupportsAVCaptureSessionPreset_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("unlockForConfiguration")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockForConfiguration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockForConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockForConfigurationHandle);
		}
	}

	[Export("defaultDeviceWithDeviceType:mediaType:position:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVCaptureDevice _DefaultDeviceWithDeviceType(NSString deviceType, string mediaType, AVCaptureDevicePosition position)
	{
		if (deviceType == null)
		{
			throw new ArgumentNullException("deviceType");
		}
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVCaptureDevice nSObject = Runtime.GetNSObject<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(class_ptr, selDefaultDeviceWithDeviceType_MediaType_Position_Handle, deviceType.Handle, arg, (long)position));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
