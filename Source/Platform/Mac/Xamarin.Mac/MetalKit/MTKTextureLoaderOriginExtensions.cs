using System;
using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTKTextureLoaderOriginExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("MTKTextureLoaderOriginTopLeft", "MetalKit")]
	internal unsafe static IntPtr MTKTextureLoaderOriginTopLeft
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.MetalKit.Handle, "MTKTextureLoaderOriginTopLeft", storage);
			}
		}
	}

	[Field("MTKTextureLoaderOriginBottomLeft", "MetalKit")]
	internal unsafe static IntPtr MTKTextureLoaderOriginBottomLeft
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.MetalKit.Handle, "MTKTextureLoaderOriginBottomLeft", storage);
			}
		}
	}

	[Field("MTKTextureLoaderOriginFlippedVertically", "MetalKit")]
	internal unsafe static IntPtr MTKTextureLoaderOriginFlippedVertically
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.MetalKit.Handle, "MTKTextureLoaderOriginFlippedVertically", storage);
			}
		}
	}

	public static NSString? GetConstant(this MTKTextureLoaderOrigin self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = MTKTextureLoaderOriginTopLeft;
			break;
		case 1:
			ptr = MTKTextureLoaderOriginBottomLeft;
			break;
		case 2:
			ptr = MTKTextureLoaderOriginFlippedVertically;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static MTKTextureLoaderOrigin GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(MTKTextureLoaderOriginTopLeft))
		{
			return MTKTextureLoaderOrigin.TopLeft;
		}
		if (constant.IsEqualTo(MTKTextureLoaderOriginBottomLeft))
		{
			return MTKTextureLoaderOrigin.BottomLeft;
		}
		if (constant.IsEqualTo(MTKTextureLoaderOriginFlippedVertically))
		{
			return MTKTextureLoaderOrigin.FlippedVertically;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
