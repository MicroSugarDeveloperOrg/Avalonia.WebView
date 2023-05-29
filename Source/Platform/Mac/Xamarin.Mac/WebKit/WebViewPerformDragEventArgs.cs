using System;
using AppKit;
using CoreGraphics;

namespace WebKit;

public class WebViewPerformDragEventArgs : EventArgs
{
	public WebDragSourceAction Action { get; set; }

	public CGPoint SourcePoint { get; set; }

	public NSPasteboard Pasteboard { get; set; }

	public WebViewPerformDragEventArgs(WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
	{
		Action = action;
		SourcePoint = sourcePoint;
		Pasteboard = pasteboard;
	}
}
