using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICDeviceCapabilities
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanAcceptPtpCommands;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanDeleteAllFiles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanDeleteOneFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanReceiveFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanSyncClock;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanTakePicture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraDeviceCanTakePictureUsingShutterReleaseOnCamera;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceCanEjectOrDisconnect;

	[Field("ICCameraDeviceCanAcceptPTPCommands", "ImageCaptureCore")]
	public static NSString CameraDeviceCanAcceptPtpCommands
	{
		get
		{
			if (_CameraDeviceCanAcceptPtpCommands == null)
			{
				_CameraDeviceCanAcceptPtpCommands = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanAcceptPTPCommands");
			}
			return _CameraDeviceCanAcceptPtpCommands;
		}
	}

	[Field("ICCameraDeviceCanDeleteAllFiles", "ImageCaptureCore")]
	public static NSString CameraDeviceCanDeleteAllFiles
	{
		get
		{
			if (_CameraDeviceCanDeleteAllFiles == null)
			{
				_CameraDeviceCanDeleteAllFiles = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanDeleteAllFiles");
			}
			return _CameraDeviceCanDeleteAllFiles;
		}
	}

	[Field("ICCameraDeviceCanDeleteOneFile", "ImageCaptureCore")]
	public static NSString CameraDeviceCanDeleteOneFile
	{
		get
		{
			if (_CameraDeviceCanDeleteOneFile == null)
			{
				_CameraDeviceCanDeleteOneFile = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanDeleteOneFile");
			}
			return _CameraDeviceCanDeleteOneFile;
		}
	}

	[Field("ICCameraDeviceCanReceiveFile", "ImageCaptureCore")]
	public static NSString CameraDeviceCanReceiveFile
	{
		get
		{
			if (_CameraDeviceCanReceiveFile == null)
			{
				_CameraDeviceCanReceiveFile = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanReceiveFile");
			}
			return _CameraDeviceCanReceiveFile;
		}
	}

	[Field("ICCameraDeviceCanSyncClock", "ImageCaptureCore")]
	public static NSString CameraDeviceCanSyncClock
	{
		get
		{
			if (_CameraDeviceCanSyncClock == null)
			{
				_CameraDeviceCanSyncClock = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanSyncClock");
			}
			return _CameraDeviceCanSyncClock;
		}
	}

	[Field("ICCameraDeviceCanTakePicture", "ImageCaptureCore")]
	public static NSString CameraDeviceCanTakePicture
	{
		get
		{
			if (_CameraDeviceCanTakePicture == null)
			{
				_CameraDeviceCanTakePicture = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanTakePicture");
			}
			return _CameraDeviceCanTakePicture;
		}
	}

	[Field("ICCameraDeviceCanTakePictureUsingShutterReleaseOnCamera", "ImageCaptureCore")]
	public static NSString CameraDeviceCanTakePictureUsingShutterReleaseOnCamera
	{
		get
		{
			if (_CameraDeviceCanTakePictureUsingShutterReleaseOnCamera == null)
			{
				_CameraDeviceCanTakePictureUsingShutterReleaseOnCamera = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICCameraDeviceCanTakePictureUsingShutterReleaseOnCamera");
			}
			return _CameraDeviceCanTakePictureUsingShutterReleaseOnCamera;
		}
	}

	[Field("ICDeviceCanEjectOrDisconnect", "ImageCaptureCore")]
	public static NSString DeviceCanEjectOrDisconnect
	{
		get
		{
			if (_DeviceCanEjectOrDisconnect == null)
			{
				_DeviceCanEjectOrDisconnect = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeviceCanEjectOrDisconnect");
			}
			return _DeviceCanEjectOrDisconnect;
		}
	}
}
