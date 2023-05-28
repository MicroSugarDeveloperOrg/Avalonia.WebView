using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

public class NCWidgetListViewControllerDidRemoveRowEventArgs : EventArgs
{
	public nuint Row { get; set; }

	public NCWidgetListViewControllerDidRemoveRowEventArgs(nuint row)
	{
		Row = row;
	}
}
