using System;
using Foundation;

namespace ImageKit;

public class IKCameraDeviceViewNSErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public IKCameraDeviceViewNSErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
