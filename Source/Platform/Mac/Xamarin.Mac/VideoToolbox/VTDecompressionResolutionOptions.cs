using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTDecompressionResolutionOptions : DictionaryContainer
{
	public float? Width
	{
		get
		{
			return GetFloatValue(VTDecompressionResolutionKeys.Width);
		}
		set
		{
			SetNumberValue(VTDecompressionResolutionKeys.Width, value);
		}
	}

	public float? Height
	{
		get
		{
			return GetFloatValue(VTDecompressionResolutionKeys.Height);
		}
		set
		{
			SetNumberValue(VTDecompressionResolutionKeys.Height, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTDecompressionResolutionOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTDecompressionResolutionOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
