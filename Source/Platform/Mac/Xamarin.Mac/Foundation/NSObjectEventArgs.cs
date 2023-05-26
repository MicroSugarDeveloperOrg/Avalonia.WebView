using System;

namespace Foundation;

public class NSObjectEventArgs : EventArgs
{
	public NSObject Obj { get; set; }

	public NSObjectEventArgs(NSObject obj)
	{
		Obj = obj;
	}
}
