using System;
using Foundation;

namespace AppKit;

public class NSPageControllerTransitionEventArgs : EventArgs
{
	public NSObject TargetObject { get; set; }

	public NSPageControllerTransitionEventArgs(NSObject targetObject)
	{
		TargetObject = targetObject;
	}
}
