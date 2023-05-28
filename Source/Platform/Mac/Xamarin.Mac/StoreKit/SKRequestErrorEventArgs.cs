using System;
using Foundation;

namespace StoreKit;

public class SKRequestErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public SKRequestErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
