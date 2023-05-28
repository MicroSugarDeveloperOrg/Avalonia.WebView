using System;
using Foundation;

namespace AppKit;

public class NSApplicationUpdatedUserActivityEventArgs : EventArgs
{
	public NSUserActivity UserActivity { get; set; }

	public NSApplicationUpdatedUserActivityEventArgs(NSUserActivity userActivity)
	{
		UserActivity = userActivity;
	}
}
