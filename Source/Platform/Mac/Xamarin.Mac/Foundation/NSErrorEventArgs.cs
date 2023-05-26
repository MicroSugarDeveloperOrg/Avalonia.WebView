using System;

namespace Foundation;

public class NSErrorEventArgs : EventArgs
{
	public NSError Error { get; private set; }

	public NSErrorEventArgs(NSError error)
	{
		Error = error;
	}
}
