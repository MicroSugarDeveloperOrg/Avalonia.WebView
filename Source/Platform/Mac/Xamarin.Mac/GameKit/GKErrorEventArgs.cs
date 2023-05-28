using System;
using Foundation;

namespace GameKit;

public class GKErrorEventArgs : EventArgs
{
	public NSError? Error { get; set; }

	public GKErrorEventArgs(NSError? error)
	{
		Error = error;
	}
}
