using System;
using Foundation;

namespace ImageKit;

public class IKScannerDeviceViewScanUrlEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public NSUrl Url { get; set; }

	public IKScannerDeviceViewScanUrlEventArgs(NSUrl url, NSError error)
	{
		Error = error;
		Url = url;
	}
}
