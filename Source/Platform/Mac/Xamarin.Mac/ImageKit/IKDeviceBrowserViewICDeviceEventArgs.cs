using System;
using ImageCaptureCore;

namespace ImageKit;

public class IKDeviceBrowserViewICDeviceEventArgs : EventArgs
{
	public ICDevice Device { get; set; }

	public IKDeviceBrowserViewICDeviceEventArgs(ICDevice device)
	{
		Device = device;
	}
}
