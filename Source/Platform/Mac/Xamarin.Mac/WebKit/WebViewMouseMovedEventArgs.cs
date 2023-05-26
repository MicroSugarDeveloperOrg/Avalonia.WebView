using System;
using AppKit;
using Foundation;

namespace WebKit;

public class WebViewMouseMovedEventArgs : EventArgs
{
	public NSDictionary ElementInformation { get; set; }

	public NSEventModifierMask ModifierFlags { get; set; }

	public WebViewMouseMovedEventArgs(NSDictionary elementInformation, NSEventModifierMask modifierFlags)
	{
		ElementInformation = elementInformation;
		ModifierFlags = modifierFlags;
	}
}
