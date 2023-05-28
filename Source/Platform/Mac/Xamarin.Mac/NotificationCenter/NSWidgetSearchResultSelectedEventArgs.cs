using System;
using Foundation;

namespace NotificationCenter;

public class NSWidgetSearchResultSelectedEventArgs : EventArgs
{
	public NSObject Obj { get; set; }

	public NSWidgetSearchResultSelectedEventArgs(NSObject obj)
	{
		Obj = obj;
	}
}
