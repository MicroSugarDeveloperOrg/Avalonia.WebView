using System.Collections.Generic;
using Foundation;

namespace AppKit;

internal static class OneShotTracker
{
	[Register("__MonoMac_OnEndTrackerDispatch")]
	internal class Dispatcher : NSObject
	{
		private NSAction action;

		public Dispatcher(NSAction action)
		{
			this.action = action;
		}

		[Export("xamarinApplySelector")]
		[Preserve(Conditional = true)]
		public void Apply()
		{
			try
			{
				action();
			}
			finally
			{
				pendingInvokes.Remove(this);
			}
		}
	}

	private static List<NSObject> pendingInvokes = new List<NSObject>();

	public static NSObject Create(NSAction action)
	{
		Dispatcher dispatcher = new Dispatcher(action);
		pendingInvokes.Add(dispatcher);
		return dispatcher;
	}
}
