using Foundation;

namespace CoreImage;

public class CIImageInitializationOptionsWithMetadata : CIImageInitializationOptions
{
	public CIImageInitializationOptionsWithMetadata()
	{
	}

	public CIImageInitializationOptionsWithMetadata(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
