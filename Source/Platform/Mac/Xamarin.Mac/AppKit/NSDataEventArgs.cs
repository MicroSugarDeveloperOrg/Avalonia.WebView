using System;
using Foundation;

namespace AppKit;

public class NSDataEventArgs : EventArgs
{
	public NSData DeviceToken { get; set; }

	public NSDataEventArgs(NSData deviceToken)
	{
		DeviceToken = deviceToken;
	}
}
