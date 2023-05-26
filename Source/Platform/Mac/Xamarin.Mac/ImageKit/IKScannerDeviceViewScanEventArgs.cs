using System;
using Foundation;

namespace ImageKit;

public class IKScannerDeviceViewScanEventArgs : EventArgs
{
	public NSUrl Url { get; set; }

	public NSData Data { get; set; }

	public NSError Error { get; set; }

	public IKScannerDeviceViewScanEventArgs(NSUrl url, NSData data, NSError error)
	{
		Url = url;
		Data = data;
		Error = error;
	}
}
