using System;

namespace ImageKit;

public class IKImageBrowserViewIndexEventArgs : EventArgs
{
	public int Index { get; set; }

	public IKImageBrowserViewIndexEventArgs(int index)
	{
		Index = index;
	}
}
