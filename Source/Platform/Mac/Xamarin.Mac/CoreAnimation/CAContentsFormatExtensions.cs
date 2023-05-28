using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CAContentsFormatExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kCAContentsFormatGray8Uint", "CoreAnimation")]
	internal unsafe static IntPtr kCAContentsFormatGray8Uint
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAContentsFormatGray8Uint", storage);
			}
		}
	}

	[Field("kCAContentsFormatRGBA8Uint", "CoreAnimation")]
	internal unsafe static IntPtr kCAContentsFormatRGBA8Uint
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAContentsFormatRGBA8Uint", storage);
			}
		}
	}

	[Field("kCAContentsFormatRGBA16Float", "CoreAnimation")]
	internal unsafe static IntPtr kCAContentsFormatRGBA16Float
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAContentsFormatRGBA16Float", storage);
			}
		}
	}

	public static NSString? GetConstant(this CAContentsFormat self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCAContentsFormatGray8Uint;
			break;
		case 1:
			zero = kCAContentsFormatRGBA8Uint;
			break;
		case 2:
			zero = kCAContentsFormatRGBA16Float;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CAContentsFormat GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCAContentsFormatGray8Uint))
		{
			return CAContentsFormat.Gray8Uint;
		}
		if (constant.IsEqualTo(kCAContentsFormatRGBA8Uint))
		{
			return CAContentsFormat.Rgba8Uint;
		}
		if (constant.IsEqualTo(kCAContentsFormatRGBA16Float))
		{
			return CAContentsFormat.Rgba16Float;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
