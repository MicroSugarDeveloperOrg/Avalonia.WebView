using System;
using Foundation;

namespace ImageKit;

public class IKDeviceBrowserViewNSErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public IKDeviceBrowserViewNSErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
