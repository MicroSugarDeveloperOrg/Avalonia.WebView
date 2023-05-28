using Foundation;

namespace Social;

public class SLRequestResult
{
	public NSData Arg1 { get; set; }

	public NSHttpUrlResponse Arg2 { get; set; }

	public SLRequestResult(NSData arg1, NSHttpUrlResponse arg2)
	{
		Arg1 = arg1;
		Arg2 = arg2;
	}
}
