using System;
using AppKit;

namespace WebKit;

public class WebViewDragEventArgs : EventArgs
{
	public WebDragDestinationAction Action { get; set; }

	public NSDraggingInfo DraggingInfo { get; set; }

	public WebViewDragEventArgs(WebDragDestinationAction action, NSDraggingInfo draggingInfo)
	{
		Action = action;
		DraggingInfo = draggingInfo;
	}
}
