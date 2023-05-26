using System;
using Foundation;

namespace AppKit;

public class NSWindowCoderEventArgs : EventArgs
{
	public NSCoder Coder { get; set; }

	public NSWindowCoderEventArgs(NSCoder coder)
	{
		Coder = coder;
	}
}
