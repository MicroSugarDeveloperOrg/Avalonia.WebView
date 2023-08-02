using System;

namespace AppKit;

public class NSPathCellDisplayPanelEventArgs : EventArgs
{
	public NSOpenPanel OpenPanel { get; set; }

	public NSPathCellDisplayPanelEventArgs(NSOpenPanel openPanel)
	{
		OpenPanel = openPanel;
	}
}
