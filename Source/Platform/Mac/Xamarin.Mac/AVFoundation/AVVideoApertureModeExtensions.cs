using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVVideoApertureModeExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("AVVideoApertureModeCleanAperture", "AVFoundation")]
	internal unsafe static IntPtr AVVideoApertureModeCleanAperture
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoApertureModeCleanAperture", storage);
			}
		}
	}

	[Field("AVVideoApertureModeProductionAperture", "AVFoundation")]
	internal unsafe static IntPtr AVVideoApertureModeProductionAperture
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoApertureModeProductionAperture", storage);
			}
		}
	}

	[Field("AVVideoApertureModeEncodedPixels", "AVFoundation")]
	internal unsafe static IntPtr AVVideoApertureModeEncodedPixels
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoApertureModeEncodedPixels", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVVideoApertureMode self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVVideoApertureModeCleanAperture;
			break;
		case 1:
			ptr = AVVideoApertureModeProductionAperture;
			break;
		case 2:
			ptr = AVVideoApertureModeEncodedPixels;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVVideoApertureMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVVideoApertureModeCleanAperture))
		{
			return AVVideoApertureMode.CleanAperture;
		}
		if (constant.IsEqualTo(AVVideoApertureModeProductionAperture))
		{
			return AVVideoApertureMode.ProductionAperture;
		}
		if (constant.IsEqualTo(AVVideoApertureModeEncodedPixels))
		{
			return AVVideoApertureMode.EncodedPixels;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
