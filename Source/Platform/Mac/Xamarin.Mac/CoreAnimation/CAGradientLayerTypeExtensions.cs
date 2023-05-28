using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CAGradientLayerTypeExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kCAGradientLayerAxial", "CoreAnimation")]
	internal unsafe static IntPtr kCAGradientLayerAxial
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAGradientLayerAxial", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("kCAGradientLayerRadial", "CoreAnimation")]
	internal unsafe static IntPtr kCAGradientLayerRadial
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAGradientLayerRadial", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("kCAGradientLayerConic", "CoreAnimation")]
	internal unsafe static IntPtr kCAGradientLayerConic
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAGradientLayerConic", storage);
			}
		}
	}

	public static NSString? GetConstant(this CAGradientLayerType self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCAGradientLayerAxial;
			break;
		case 1:
			zero = kCAGradientLayerRadial;
			break;
		case 2:
			zero = kCAGradientLayerConic;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CAGradientLayerType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCAGradientLayerAxial))
		{
			return CAGradientLayerType.Axial;
		}
		if (constant.IsEqualTo(kCAGradientLayerRadial))
		{
			return CAGradientLayerType.Radial;
		}
		if (constant.IsEqualTo(kCAGradientLayerConic))
		{
			return CAGradientLayerType.Conic;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
