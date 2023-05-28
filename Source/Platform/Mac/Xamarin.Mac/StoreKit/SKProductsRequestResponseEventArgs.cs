using System;

namespace StoreKit;

public class SKProductsRequestResponseEventArgs : EventArgs
{
	public SKProductsResponse Response { get; set; }

	public SKProductsRequestResponseEventArgs(SKProductsResponse response)
	{
		Response = response;
	}
}
