using System;

namespace AppKit;

public class NSOpenSaveExpandingEventArgs : EventArgs
{
	public bool Expanding { get; set; }

	public NSOpenSaveExpandingEventArgs(bool expanding)
	{
		Expanding = expanding;
	}
}
