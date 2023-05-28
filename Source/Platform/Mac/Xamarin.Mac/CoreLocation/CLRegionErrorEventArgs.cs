using System;
using Foundation;

namespace CoreLocation;

public class CLRegionErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public CLRegion? Region { get; set; }

	public CLRegionErrorEventArgs(CLRegion? region, NSError error)
	{
		Error = error;
		Region = region;
	}
}
