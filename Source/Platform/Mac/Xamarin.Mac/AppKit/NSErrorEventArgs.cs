using System;
using Foundation;

namespace AppKit;

public class NSErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public NSErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
