using System;

namespace Foundation;

public class NSArchiveReplaceEventArgs : EventArgs
{
	public NSObject OldObject { get; set; }

	public NSObject NewObject { get; set; }

	public NSArchiveReplaceEventArgs(NSObject oldObject, NSObject newObject)
	{
		OldObject = oldObject;
		NewObject = newObject;
	}
}
