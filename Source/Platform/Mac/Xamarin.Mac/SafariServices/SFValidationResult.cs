using Foundation;

namespace SafariServices;

public class SFValidationResult
{
	public bool Arg1 { get; set; }

	public NSString Arg2 { get; set; }

	public SFValidationResult(bool arg1, NSString arg2)
	{
		Arg1 = arg1;
		Arg2 = arg2;
	}
}
