using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("__MonoMac_NSAlertDidEndDispatcher")]
internal class NSAlertDidEndDispatcher : NSObject
{
	private const string selector = "alertDidEnd:returnCode:contextInfo:";

	public static readonly Selector Selector = new Selector("alertDidEnd:returnCode:contextInfo:");

	private Action<nint> action;

	public NSAlertDidEndDispatcher(Action<nint> action)
	{
		this.action = action;
		base.IsDirectBinding = false;
		DangerousRetain();
	}

	[Export("alertDidEnd:returnCode:contextInfo:")]
	[Preserve(Conditional = true)]
	public void OnAlertDidEnd(NSAlert alert, nint returnCode, IntPtr context)
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
			DangerousRelease();
		}
	}
}
