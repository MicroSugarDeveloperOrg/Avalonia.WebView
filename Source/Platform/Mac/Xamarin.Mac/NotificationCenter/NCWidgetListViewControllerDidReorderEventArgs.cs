using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

public class NCWidgetListViewControllerDidReorderEventArgs : EventArgs
{
	public nuint NewIndex { get; set; }

	public nuint Row { get; set; }

	public NCWidgetListViewControllerDidReorderEventArgs(nuint row, nuint newIndex)
	{
		NewIndex = newIndex;
		Row = row;
	}
}
