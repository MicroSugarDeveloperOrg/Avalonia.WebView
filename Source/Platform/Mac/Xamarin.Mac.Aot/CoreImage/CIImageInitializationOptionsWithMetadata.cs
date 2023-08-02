using CoreGraphics;
using Foundation;

namespace CoreImage;

public class CIImageInitializationOptionsWithMetadata : CIImageInitializationOptions
{
	public CGImageProperties Properties
	{
		set
		{
			SetNativeValue(CIImage.CIImagePropertiesKey, value?.Dictionary, removeNullValue: false);
		}
	}

	public CIImageInitializationOptionsWithMetadata()
	{
	}

	public CIImageInitializationOptionsWithMetadata(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
