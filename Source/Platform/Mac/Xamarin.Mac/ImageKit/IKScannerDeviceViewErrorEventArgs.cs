using System;
using Foundation;

namespace ImageKit;

public class IKScannerDeviceViewErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public IKScannerDeviceViewErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
