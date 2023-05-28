using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class IKOverlayTypeExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("IKOverlayTypeBackground", "ImageKit")]
	internal unsafe static IntPtr IKOverlayTypeBackground
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKOverlayTypeBackground", storage);
			}
		}
	}

	[Field("IKOverlayTypeImage", "ImageKit")]
	internal unsafe static IntPtr IKOverlayTypeImage
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKOverlayTypeImage", storage);
			}
		}
	}

	public static NSString? GetConstant(this IKOverlayType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = IKOverlayTypeBackground;
			break;
		case 1:
			ptr = IKOverlayTypeImage;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static IKOverlayType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(IKOverlayTypeBackground))
		{
			return IKOverlayType.Background;
		}
		if (constant.IsEqualTo(IKOverlayTypeImage))
		{
			return IKOverlayType.Image;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
