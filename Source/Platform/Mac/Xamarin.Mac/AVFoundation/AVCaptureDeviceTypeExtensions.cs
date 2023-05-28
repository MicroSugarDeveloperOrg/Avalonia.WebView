using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVCaptureDeviceTypeExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("AVCaptureDeviceTypeBuiltInMicrophone", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInMicrophone
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInMicrophone", storage);
			}
		}
	}

	[Field("AVCaptureDeviceTypeBuiltInWideAngleCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInWideAngleCamera
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInWideAngleCamera", storage);
			}
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Field("AVCaptureDeviceTypeExternalUnknown", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeExternalUnknown
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeExternalUnknown", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVCaptureDeviceType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVCaptureDeviceTypeBuiltInMicrophone;
			break;
		case 1:
			ptr = AVCaptureDeviceTypeBuiltInWideAngleCamera;
			break;
		case 9:
			ptr = AVCaptureDeviceTypeExternalUnknown;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVCaptureDeviceType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVCaptureDeviceTypeBuiltInMicrophone))
		{
			return AVCaptureDeviceType.BuiltInMicrophone;
		}
		if (constant.IsEqualTo(AVCaptureDeviceTypeBuiltInWideAngleCamera))
		{
			return AVCaptureDeviceType.BuiltInWideAngleCamera;
		}
		if (constant.IsEqualTo(AVCaptureDeviceTypeExternalUnknown))
		{
			return AVCaptureDeviceType.ExternalUnknown;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
