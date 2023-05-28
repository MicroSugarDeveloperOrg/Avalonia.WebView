using System;
using Foundation;

namespace ImageKit;

public class IKScannerDeviceViewScanEventArgs : EventArgs
{
	public NSData Data { get; set; }

	public NSError Error { get; set; }

	public NSUrl Url { get; set; }

	public IKScannerDeviceViewScanEventArgs(NSUrl url, NSData data, NSError error)
	{
		Data = data;
		Error = error;
		Url = url;
	}
}
