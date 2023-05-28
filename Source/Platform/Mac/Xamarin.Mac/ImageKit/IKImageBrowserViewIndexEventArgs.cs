using Xamarin.Mac.System.Mac;

namespace ImageKit;

public class IKImageBrowserViewIndexEventArgs : EventArgs
{
	public nint Index { get; set; }

	public IKImageBrowserViewIndexEventArgs(nint index)
	{
		Index = index;
	}
}
