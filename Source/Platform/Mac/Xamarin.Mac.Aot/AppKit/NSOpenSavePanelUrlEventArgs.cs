using System;
using Foundation;

namespace AppKit;

public class NSOpenSavePanelUrlEventArgs : EventArgs
{
	public NSUrl NewDirectoryUrl { get; set; }

	public NSOpenSavePanelUrlEventArgs(NSUrl newDirectoryUrl)
	{
		NewDirectoryUrl = newDirectoryUrl;
	}
}
