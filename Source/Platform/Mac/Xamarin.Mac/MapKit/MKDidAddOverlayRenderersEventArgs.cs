using System;

namespace MapKit;

public class MKDidAddOverlayRenderersEventArgs : EventArgs
{
	public MKOverlayRenderer[] Renderers { get; set; }

	public MKDidAddOverlayRenderersEventArgs(MKOverlayRenderer[] renderers)
	{
		Renderers = renderers;
	}
}
