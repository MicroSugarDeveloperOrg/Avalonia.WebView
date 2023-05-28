using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
internal static class MTKTextureLoaderKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllocateMipmapsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CubeLayoutKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenerateMipmapsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OriginKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SrgbKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextureCpuCacheModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextureStorageModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextureUsageKey;

	[Field("MTKTextureLoaderOptionAllocateMipmaps", "MetalKit")]
	public static NSString AllocateMipmapsKey
	{
		get
		{
			if (_AllocateMipmapsKey == null)
			{
				_AllocateMipmapsKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionAllocateMipmaps");
			}
			return _AllocateMipmapsKey;
		}
	}

	[Field("MTKTextureLoaderOptionCubeLayout", "MetalKit")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString CubeLayoutKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CubeLayoutKey == null)
			{
				_CubeLayoutKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionCubeLayout");
			}
			return _CubeLayoutKey;
		}
	}

	[Field("MTKTextureLoaderOptionGenerateMipmaps", "MetalKit")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString GenerateMipmapsKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GenerateMipmapsKey == null)
			{
				_GenerateMipmapsKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionGenerateMipmaps");
			}
			return _GenerateMipmapsKey;
		}
	}

	[Field("MTKTextureLoaderOptionOrigin", "MetalKit")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString OriginKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OriginKey == null)
			{
				_OriginKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionOrigin");
			}
			return _OriginKey;
		}
	}

	[Field("MTKTextureLoaderOptionSRGB", "MetalKit")]
	public static NSString SrgbKey
	{
		get
		{
			if (_SrgbKey == null)
			{
				_SrgbKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionSRGB");
			}
			return _SrgbKey;
		}
	}

	[Field("MTKTextureLoaderOptionTextureCPUCacheMode", "MetalKit")]
	public static NSString TextureCpuCacheModeKey
	{
		get
		{
			if (_TextureCpuCacheModeKey == null)
			{
				_TextureCpuCacheModeKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureCPUCacheMode");
			}
			return _TextureCpuCacheModeKey;
		}
	}

	[Field("MTKTextureLoaderOptionTextureStorageMode", "MetalKit")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString TextureStorageModeKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TextureStorageModeKey == null)
			{
				_TextureStorageModeKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureStorageMode");
			}
			return _TextureStorageModeKey;
		}
	}

	[Field("MTKTextureLoaderOptionTextureUsage", "MetalKit")]
	public static NSString TextureUsageKey
	{
		get
		{
			if (_TextureUsageKey == null)
			{
				_TextureUsageKey = Dlfcn.GetStringConstant(Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureUsage");
			}
			return _TextureUsageKey;
		}
	}
}
