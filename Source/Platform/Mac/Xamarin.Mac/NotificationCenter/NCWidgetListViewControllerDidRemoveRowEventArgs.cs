using System;

namespace NotificationCenter;

public class NCWidgetListViewControllerDidRemoveRowEventArgs : EventArgs
{
	public nuint Row { get; set; }

	public NCWidgetListViewControllerDidRemoveRowEventArgs(nuint row)
	{
		Row = row;
	}
}
