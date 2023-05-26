using Foundation;
using ObjCRuntime;

namespace GLKit;

[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKTextureOperations : DictionaryContainer
{
	public bool? ApplyPremultiplication
	{
		get
		{
			return GetBoolValue(GLKTextureLoader.ApplyPremultiplication);
		}
		set
		{
			SetBooleanValue(GLKTextureLoader.ApplyPremultiplication, value);
		}
	}

	public bool? OriginBottomLeft
	{
		get
		{
			return GetBoolValue(GLKTextureLoader.OriginBottomLeft);
		}
		set
		{
			SetBooleanValue(GLKTextureLoader.OriginBottomLeft, value);
		}
	}

	public bool? GenerateMipmaps
	{
		get
		{
			return GetBoolValue(GLKTextureLoader.GenerateMipmaps);
		}
		set
		{
			SetBooleanValue(GLKTextureLoader.GenerateMipmaps, value);
		}
	}

	public bool? GrayscaleAsAlpha
	{
		get
		{
			return GetBoolValue(GLKTextureLoader.GrayscaleAsAlpha);
		}
		set
		{
			SetBooleanValue(GLKTextureLoader.GrayscaleAsAlpha, value);
		}
	}

	[iOS(7, 0)]
	public bool? SRGB
	{
		get
		{
			return GetBoolValue(GLKTextureLoader.SRGB);
		}
		set
		{
			SetBooleanValue(GLKTextureLoader.SRGB, value);
		}
	}

	public GLKTextureOperations()
		: base(new NSMutableDictionary())
	{
	}

	public GLKTextureOperations(NSDictionary options)
		: base(options)
	{
	}
}
