using System;

namespace WebKit;

public class DomEventArgs : EventArgs
{
	public DomEvent Event { get; set; }

	public DomEventArgs(DomEvent evt)
	{
		Event = evt;
	}
}
