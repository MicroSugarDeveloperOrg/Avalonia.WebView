using System;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VTAlphaChannelModeExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("kVTAlphaChannelMode_StraightAlpha", "VideoToolbox")]
	internal unsafe static IntPtr kVTAlphaChannelMode_StraightAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.VideoToolbox.Handle, "kVTAlphaChannelMode_StraightAlpha", storage);
			}
		}
	}

	[Field("kVTAlphaChannelMode_PremultipliedAlpha", "VideoToolbox")]
	internal unsafe static IntPtr kVTAlphaChannelMode_PremultipliedAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.VideoToolbox.Handle, "kVTAlphaChannelMode_PremultipliedAlpha", storage);
			}
		}
	}

	public static NSString? GetConstant(this VTAlphaChannelMode self)
	{
		IntPtr zero = IntPtr.Zero;
		return (NSString)Runtime.GetNSObject((int)self switch
		{
			0 => kVTAlphaChannelMode_StraightAlpha, 
			_ => kVTAlphaChannelMode_PremultipliedAlpha, 
		});
	}

	public static VTAlphaChannelMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kVTAlphaChannelMode_StraightAlpha))
		{
			return VTAlphaChannelMode.StraightAlpha;
		}
		if (constant.IsEqualTo(kVTAlphaChannelMode_PremultipliedAlpha))
		{
			return VTAlphaChannelMode.PremultipliedAlpha;
		}
		return VTAlphaChannelMode.PremultipliedAlpha;
	}
}
