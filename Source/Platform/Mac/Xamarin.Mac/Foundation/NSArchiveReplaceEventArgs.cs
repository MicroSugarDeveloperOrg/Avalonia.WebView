using System;

namespace Foundation;

public class NSArchiveReplaceEventArgs : EventArgs
{
	public NSObject NewObject { get; set; }

	public NSObject OldObject { get; set; }

	public NSArchiveReplaceEventArgs(NSObject oldObject, NSObject newObject)
	{
		NewObject = newObject;
		OldObject = oldObject;
	}
}
