using System;
using Foundation;

namespace AppKit;

public class NSPageControllerPrepareViewControllerEventArgs : EventArgs
{
	public NSObject TargetObject { get; set; }

	public NSViewController ViewController { get; set; }

	public NSPageControllerPrepareViewControllerEventArgs(NSViewController viewController, NSObject targetObject)
	{
		TargetObject = targetObject;
		ViewController = viewController;
	}
}
