using System;
using System.Collections.Generic;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("__MonoMac_NSAlertDidEndDispatcher")]
internal class NSAlertDidEndDispatcher : NSObject
{
	private static List<NSAlertDidEndDispatcher> pendingInvokes = new List<NSAlertDidEndDispatcher>();

	private const string selector = "alertDidEnd:returnCode:contextInfo:";

	public static readonly Selector Selector = new Selector("alertDidEnd:returnCode:contextInfo:");

	private Action<int> action;

	public NSAlertDidEndDispatcher(Action<int> action)
	{
		this.action = action;
		pendingInvokes.Add(this);
	}

	[Export("alertDidEnd:returnCode:contextInfo:")]
	[Preserve(Conditional = true)]
	public void OnAlertDidEnd(NSAlert alert, int returnCode, IntPtr context)
	{
		try
		{
			if (action != null)
			{
				action(returnCode);
			}
		}
		finally
		{
			action = null;
			pendingInvokes.Remove(this);
		}
	}
}
