using System;

namespace MapKit;

public class MKDidFinishRenderingMapEventArgs : EventArgs
{
	public bool FullyRendered { get; set; }

	public MKDidFinishRenderingMapEventArgs(bool fullyRendered)
	{
		FullyRendered = fullyRendered;
	}
}
