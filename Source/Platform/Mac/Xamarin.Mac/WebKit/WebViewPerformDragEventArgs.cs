using System;
using AppKit;
using CoreGraphics;

namespace WebKit;

public class WebViewPerformDragEventArgs : EventArgs
{
	public WebDragSourceAction Action { get; set; }

	public NSPasteboard Pasteboard { get; set; }

	public CGPoint SourcePoint { get; set; }

	public WebViewPerformDragEventArgs(WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
	{
		Action = action;
		Pasteboard = pasteboard;
		SourcePoint = sourcePoint;
	}
}
