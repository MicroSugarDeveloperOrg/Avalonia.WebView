using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVColorProperties : DictionaryContainer
{
	public NSString? AVVideoColorPrimaries
	{
		get
		{
			return GetNSStringValue(AVColorPropertiesKeys.AVVideoColorPrimariesKey);
		}
		set
		{
			SetStringValue(AVColorPropertiesKeys.AVVideoColorPrimariesKey, value);
		}
	}

	public NSString? AVVideoTransferFunction
	{
		get
		{
			return GetNSStringValue(AVColorPropertiesKeys.AVVideoTransferFunctionKey);
		}
		set
		{
			SetStringValue(AVColorPropertiesKeys.AVVideoTransferFunctionKey, value);
		}
	}

	public NSString? AVVideoYCbCrMatrix => GetNSStringValue(AVColorPropertiesKeys.AVVideoYCbCrMatrixKey);

	[Preserve(Conditional = true)]
	public AVColorProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVColorProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
