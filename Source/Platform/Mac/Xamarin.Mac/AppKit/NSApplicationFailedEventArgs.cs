using System;
using Foundation;

namespace AppKit;

public class NSApplicationFailedEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public string UserActivityType { get; set; }

	public NSApplicationFailedEventArgs(string userActivityType, NSError error)
	{
		Error = error;
		UserActivityType = userActivityType;
	}
}
