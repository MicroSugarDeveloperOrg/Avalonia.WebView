using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalKit;

[iOS(9, 0)]
[Mac(10, 11)]
public class MTKTextureLoaderOptions : DictionaryContainer
{
	public MTLTextureUsage? TextureUsage
	{
		get
		{
			nuint? nUIntValue = GetNUIntValue(MTKTextureLoaderKeys.TextureUsageKey);
			if (nUIntValue.HasValue)
			{
				return (MTLTextureUsage)(uint)nUIntValue.Value;
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				SetNumberValue(MTKTextureLoaderKeys.TextureUsageKey, (nuint?)(nuint)(uint)value.Value);
			}
			else
			{
				RemoveValue(MTKTextureLoaderKeys.TextureUsageKey);
			}
		}
	}

	public MTLCpuCacheMode? TextureCpuCacheMode
	{
		get
		{
			nuint? nUIntValue = GetNUIntValue(MTKTextureLoaderKeys.TextureCpuCacheModeKey);
			if (nUIntValue.HasValue)
			{
				return (MTLCpuCacheMode)(uint)nUIntValue.Value;
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				SetNumberValue(MTKTextureLoaderKeys.TextureCpuCacheModeKey, (nuint?)(nuint)(uint)value.Value);
			}
			else
			{
				RemoveValue(MTKTextureLoaderKeys.TextureCpuCacheModeKey);
			}
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public MTLStorageMode? TextureStorageMode
	{
		get
		{
			nuint? nUIntValue = GetNUIntValue(MTKTextureLoaderKeys.TextureStorageModeKey);
			if (nUIntValue.HasValue)
			{
				return (MTLStorageMode)(uint)nUIntValue.Value;
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				SetNumberValue(MTKTextureLoaderKeys.TextureStorageModeKey, (nuint?)(nuint)(uint)value.Value);
			}
			else
			{
				RemoveValue(MTKTextureLoaderKeys.TextureStorageModeKey);
			}
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public MTKTextureLoaderCubeLayout? CubeLayout
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(MTKTextureLoaderKeys.CubeLayoutKey);
			if (nSStringValue == null)
			{
				return null;
			}
			return MTKTextureLoaderCubeLayoutExtensions.GetValue(nSStringValue);
		}
		set
		{
			if (value.HasValue)
			{
				SetStringValue(MTKTextureLoaderKeys.CubeLayoutKey, value.Value.GetConstant());
			}
			else
			{
				RemoveValue(MTKTextureLoaderKeys.CubeLayoutKey);
			}
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public MTKTextureLoaderOrigin? Origin
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(MTKTextureLoaderKeys.OriginKey);
			if (nSStringValue == null)
			{
				return null;
			}
			return MTKTextureLoaderOriginExtensions.GetValue(nSStringValue);
		}
		set
		{
			if (value.HasValue)
			{
				SetStringValue(MTKTextureLoaderKeys.OriginKey, value.Value.GetConstant());
			}
			else
			{
				RemoveValue(MTKTextureLoaderKeys.OriginKey);
			}
		}
	}

	public bool? AllocateMipmaps
	{
		get
		{
			return GetBoolValue(MTKTextureLoaderKeys.AllocateMipmapsKey);
		}
		set
		{
			SetBooleanValue(MTKTextureLoaderKeys.AllocateMipmapsKey, value);
		}
	}

	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public bool? GenerateMipmaps => GetBoolValue(MTKTextureLoaderKeys.GenerateMipmapsKey);

	public bool? Srgb
	{
		get
		{
			return GetBoolValue(MTKTextureLoaderKeys.SrgbKey);
		}
		set
		{
			SetBooleanValue(MTKTextureLoaderKeys.SrgbKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public MTKTextureLoaderOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public MTKTextureLoaderOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
