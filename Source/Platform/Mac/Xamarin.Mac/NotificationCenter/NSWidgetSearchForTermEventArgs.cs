using System;

namespace NotificationCenter;

public class NSWidgetSearchForTermEventArgs : EventArgs
{
	public nuint Max { get; set; }

	public string SearchTerm { get; set; }

	public NSWidgetSearchForTermEventArgs(string searchTerm, nuint max)
	{
		Max = max;
		SearchTerm = searchTerm;
	}
}
