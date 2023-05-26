using System;
using Foundation;

namespace AVFoundation;

public class AVErrorEventArgs : EventArgs
{
	public NSError Error { get; private set; }

	public AVErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
