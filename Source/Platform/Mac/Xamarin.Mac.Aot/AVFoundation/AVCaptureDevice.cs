using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDevice", true)]
public class AVCaptureDevice : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveWasConnected(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WasConnectedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasDisconnected(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDisconnectedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	private static readonly IntPtr selModelIDHandle = Selector.GetHandle("modelID");

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	private static readonly IntPtr selIsConnectedHandle = Selector.GetHandle("isConnected");

	private static readonly IntPtr selDevicesHandle = Selector.GetHandle("devices");

	private static readonly IntPtr selFlashModeHandle = Selector.GetHandle("flashMode");

	private static readonly IntPtr selSetFlashMode_Handle = Selector.GetHandle("setFlashMode:");

	private static readonly IntPtr selTorchModeHandle = Selector.GetHandle("torchMode");

	private static readonly IntPtr selSetTorchMode_Handle = Selector.GetHandle("setTorchMode:");

	private static readonly IntPtr selFocusModeHandle = Selector.GetHandle("focusMode");

	private static readonly IntPtr selSetFocusMode_Handle = Selector.GetHandle("setFocusMode:");

	private static readonly IntPtr selIsFocusPointOfInterestSupportedHandle = Selector.GetHandle("isFocusPointOfInterestSupported");

	private static readonly IntPtr selFocusPointOfInterestHandle = Selector.GetHandle("focusPointOfInterest");

	private static readonly IntPtr selSetFocusPointOfInterest_Handle = Selector.GetHandle("setFocusPointOfInterest:");

	private static readonly IntPtr selIsAdjustingFocusHandle = Selector.GetHandle("isAdjustingFocus");

	private static readonly IntPtr selExposureModeHandle = Selector.GetHandle("exposureMode");

	private static readonly IntPtr selSetExposureMode_Handle = Selector.GetHandle("setExposureMode:");

	private static readonly IntPtr selIsExposurePointOfInterestSupportedHandle = Selector.GetHandle("isExposurePointOfInterestSupported");

	private static readonly IntPtr selExposurePointOfInterestHandle = Selector.GetHandle("exposurePointOfInterest");

	private static readonly IntPtr selSetExposurePointOfInterest_Handle = Selector.GetHandle("setExposurePointOfInterest:");

	private static readonly IntPtr selIsAdjustingExposureHandle = Selector.GetHandle("isAdjustingExposure");

	private static readonly IntPtr selWhiteBalanceModeHandle = Selector.GetHandle("whiteBalanceMode");

	private static readonly IntPtr selSetWhiteBalanceMode_Handle = Selector.GetHandle("setWhiteBalanceMode:");

	private static readonly IntPtr selIsAdjustingWhiteBalanceHandle = Selector.GetHandle("isAdjustingWhiteBalance");

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	private static readonly IntPtr selDevicesWithMediaType_Handle = Selector.GetHandle("devicesWithMediaType:");

	private static readonly IntPtr selDefaultDeviceWithMediaType_Handle = Selector.GetHandle("defaultDeviceWithMediaType:");

	private static readonly IntPtr selDeviceWithUniqueID_Handle = Selector.GetHandle("deviceWithUniqueID:");

	private static readonly IntPtr selHasMediaType_Handle = Selector.GetHandle("hasMediaType:");

	private static readonly IntPtr selLockForConfiguration_Handle = Selector.GetHandle("lockForConfiguration:");

	private static readonly IntPtr selUnlockForConfigurationHandle = Selector.GetHandle("unlockForConfiguration");

	private static readonly IntPtr selSupportsAVCaptureSessionPreset_Handle = Selector.GetHandle("supportsAVCaptureSessionPreset:");

	private static readonly IntPtr selIsFlashModeSupported_Handle = Selector.GetHandle("isFlashModeSupported:");

	private static readonly IntPtr selIsTorchModeSupported_Handle = Selector.GetHandle("isTorchModeSupported:");

	private static readonly IntPtr selIsFocusModeSupported_Handle = Selector.GetHandle("isFocusModeSupported:");

	private static readonly IntPtr selIsExposureModeSupported_Handle = Selector.GetHandle("isExposureModeSupported:");

	private static readonly IntPtr selIsWhiteBalanceModeSupported_Handle = Selector.GetHandle("isWhiteBalanceModeSupported:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureDevice");

	private static object __mt_Devices_var_static;

	private static NSString _WasConnectedNotification;

	private static NSString _WasDisconnectedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string UniqueID
	{
		[Export("uniqueID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle));
		}
	}

	public virtual string ModelID
	{
		[Export("modelID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModelIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelIDHandle));
		}
	}

	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	public virtual bool Connected
	{
		[Export("isConnected")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConnectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConnectedHandle);
		}
	}

	public static AVCaptureDevice[] Devices
	{
		[Export("devices")]
		get
		{
			return (AVCaptureDevice[])(__mt_Devices_var_static = NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend(class_ptr, selDevicesHandle)));
		}
	}

	public virtual AVCaptureFlashMode FlashMode
	{
		[Export("flashMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureFlashMode)Messaging.int_objc_msgSend(base.Handle, selFlashModeHandle);
			}
			return (AVCaptureFlashMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selFlashModeHandle);
		}
		[Export("setFlashMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetFlashMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetFlashMode_Handle, (int)value);
			}
		}
	}

	public virtual AVCaptureTorchMode TorchMode
	{
		[Export("torchMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureTorchMode)Messaging.int_objc_msgSend(base.Handle, selTorchModeHandle);
			}
			return (AVCaptureTorchMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTorchModeHandle);
		}
		[Export("setTorchMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTorchMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTorchMode_Handle, (int)value);
			}
		}
	}

	public virtual AVCaptureFocusMode FocusMode
	{
		[Export("focusMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureFocusMode)Messaging.int_objc_msgSend(base.Handle, selFocusModeHandle);
			}
			return (AVCaptureFocusMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selFocusModeHandle);
		}
		[Export("setFocusMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetFocusMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetFocusMode_Handle, (int)value);
			}
		}
	}

	public virtual bool FocusPointOfInterestSupported
	{
		[Export("isFocusPointOfInterestSupported")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFocusPointOfInterestSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFocusPointOfInterestSupportedHandle);
		}
	}

	public virtual CGPoint FocusPointOfInterest
	{
		[Export("focusPointOfInterest")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selFocusPointOfInterestHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selFocusPointOfInterestHandle);
		}
		[Export("setFocusPointOfInterest:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFocusPointOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFocusPointOfInterest_Handle, value);
			}
		}
	}

	public virtual bool AdjustingFocus
	{
		[Export("isAdjustingFocus")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingFocusHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingFocusHandle);
		}
	}

	public virtual AVCaptureExposureMode ExposureMode
	{
		[Export("exposureMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureExposureMode)Messaging.int_objc_msgSend(base.Handle, selExposureModeHandle);
			}
			return (AVCaptureExposureMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selExposureModeHandle);
		}
		[Export("setExposureMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetExposureMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetExposureMode_Handle, (int)value);
			}
		}
	}

	public virtual bool ExposurePointOfInterestSupported
	{
		[Export("isExposurePointOfInterestSupported")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExposurePointOfInterestSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExposurePointOfInterestSupportedHandle);
		}
	}

	public virtual CGPoint ExposurePointOfInterest
	{
		[Export("exposurePointOfInterest")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selExposurePointOfInterestHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selExposurePointOfInterestHandle);
		}
		[Export("setExposurePointOfInterest:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetExposurePointOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetExposurePointOfInterest_Handle, value);
			}
		}
	}

	public virtual bool AdjustingExposure
	{
		[Export("isAdjustingExposure")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingExposureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingExposureHandle);
		}
	}

	public virtual AVCaptureWhiteBalanceMode WhiteBalanceMode
	{
		[Export("whiteBalanceMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureWhiteBalanceMode)Messaging.int_objc_msgSend(base.Handle, selWhiteBalanceModeHandle);
			}
			return (AVCaptureWhiteBalanceMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selWhiteBalanceModeHandle);
		}
		[Export("setWhiteBalanceMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetWhiteBalanceMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetWhiteBalanceMode_Handle, (int)value);
			}
		}
	}

	public virtual bool AdjustingWhiteBalance
	{
		[Export("isAdjustingWhiteBalance")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdjustingWhiteBalanceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdjustingWhiteBalanceHandle);
		}
	}

	public virtual AVCaptureDevicePosition Position
	{
		[Export("position")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVCaptureDevicePosition)Messaging.int_objc_msgSend(base.Handle, selPositionHandle);
			}
			return (AVCaptureDevicePosition)Messaging.int_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
	}

	[Field("AVCaptureDeviceWasConnectedNotification", "AVFoundation")]
	public static NSString WasConnectedNotification
	{
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
	public static NSString WasDisconnectedNotification
	{
		get
		{
			if (_WasDisconnectedNotification == null)
			{
				_WasDisconnectedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureDeviceWasDisconnectedNotification");
			}
			return _WasDisconnectedNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureDevice(NSCoder coder)
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
	public AVCaptureDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("devicesWithMediaType:")]
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

	[Export("defaultDeviceWithMediaType:")]
	public static AVCaptureDevice DefaultDeviceWithMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVCaptureDevice result = (AVCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultDeviceWithMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("deviceWithUniqueID:")]
	public static AVCaptureDevice DeviceWithUniqueID(string deviceUniqueID)
	{
		if (deviceUniqueID == null)
		{
			throw new ArgumentNullException("deviceUniqueID");
		}
		IntPtr arg = NSString.CreateNative(deviceUniqueID);
		AVCaptureDevice result = (AVCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceWithUniqueID_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasMediaType:")]
	public virtual bool HasMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaType_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("lockForConfiguration:")]
	public virtual bool LockForConfiguration(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockForConfiguration_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLockForConfiguration_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("unlockForConfiguration")]
	public virtual void UnlockForConfiguration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockForConfigurationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockForConfigurationHandle);
		}
	}

	[Export("supportsAVCaptureSessionPreset:")]
	public virtual bool SupportsAVCaptureSessionPreset(string preset)
	{
		if (preset == null)
		{
			throw new ArgumentNullException("preset");
		}
		IntPtr arg = NSString.CreateNative(preset);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSupportsAVCaptureSessionPreset_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSupportsAVCaptureSessionPreset_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isFlashModeSupported:")]
	public virtual bool IsFlashModeSupported(AVCaptureFlashMode flashMode)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsFlashModeSupported_Handle, (int)flashMode);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsFlashModeSupported_Handle, (int)flashMode);
	}

	[Export("isTorchModeSupported:")]
	public virtual bool IsTorchModeSupported(AVCaptureTorchMode torchMode)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsTorchModeSupported_Handle, (int)torchMode);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsTorchModeSupported_Handle, (int)torchMode);
	}

	[Export("isFocusModeSupported:")]
	public virtual bool IsFocusModeSupported(AVCaptureFocusMode focusMode)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsFocusModeSupported_Handle, (int)focusMode);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsFocusModeSupported_Handle, (int)focusMode);
	}

	[Export("isExposureModeSupported:")]
	public virtual bool IsExposureModeSupported(AVCaptureExposureMode exposureMode)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsExposureModeSupported_Handle, (int)exposureMode);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsExposureModeSupported_Handle, (int)exposureMode);
	}

	[Export("isWhiteBalanceModeSupported:")]
	public virtual bool IsWhiteBalanceModeSupported(AVCaptureWhiteBalanceMode whiteBalanceMode)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsWhiteBalanceModeSupported_Handle, (int)whiteBalanceMode);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsWhiteBalanceModeSupported_Handle, (int)whiteBalanceMode);
	}
}
