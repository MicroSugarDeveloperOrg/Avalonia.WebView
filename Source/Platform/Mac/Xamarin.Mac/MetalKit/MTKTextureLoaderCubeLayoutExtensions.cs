using System;
using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTKTextureLoaderCubeLayoutExtensions
{
	private static IntPtr[] values = new IntPtr[1];

	[Field("MTKTextureLoaderCubeLayoutVertical", "MetalKit")]
	internal unsafe static IntPtr MTKTextureLoaderCubeLayoutVertical
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.MetalKit.Handle, "MTKTextureLoaderCubeLayoutVertical", storage);
			}
		}
	}

	public static NSString? GetConstant(this MTKTextureLoaderCubeLayout self)
	{
		IntPtr ptr = IntPtr.Zero;
		if (self == MTKTextureLoaderCubeLayout.Vertical)
		{
			ptr = MTKTextureLoaderCubeLayoutVertical;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static MTKTextureLoaderCubeLayout GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(MTKTextureLoaderCubeLayoutVertical))
		{
			return MTKTextureLoaderCubeLayout.Vertical;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
