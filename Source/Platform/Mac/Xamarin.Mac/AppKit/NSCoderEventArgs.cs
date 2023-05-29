using System;
using Foundation;

namespace AppKit;

public class NSCoderEventArgs : EventArgs
{
	public NSCoder Encoder { get; set; }

	public NSCoderEventArgs(NSCoder encoder)
	{
		Encoder = encoder;
	}
}
