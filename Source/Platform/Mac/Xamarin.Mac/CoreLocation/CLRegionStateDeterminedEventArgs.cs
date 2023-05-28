using System;

namespace CoreLocation;

public class CLRegionStateDeterminedEventArgs : EventArgs
{
	public CLRegion Region { get; set; }

	public CLRegionState State { get; set; }

	public CLRegionStateDeterminedEventArgs(CLRegionState state, CLRegion region)
	{
		Region = region;
		State = state;
	}
}
