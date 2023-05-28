using System;
using Foundation;

namespace AppKit;

public class NSCoderEventArgs : EventArgs
{
	public NSCoder State { get; set; }

	public NSCoderEventArgs(NSCoder state)
	{
		State = state;
	}
}
