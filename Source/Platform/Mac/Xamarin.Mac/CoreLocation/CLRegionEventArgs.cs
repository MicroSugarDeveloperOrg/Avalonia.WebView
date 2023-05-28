using System;

namespace CoreLocation;

public class CLRegionEventArgs : EventArgs
{
	public CLRegion Region { get; set; }

	public CLRegionEventArgs(CLRegion region)
	{
		Region = region;
	}
}
